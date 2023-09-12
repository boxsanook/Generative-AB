Imports System.ServiceProcess
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class MySQLHelper
    Public ConnectionString As String
    'Private Connection As MySqlConnection
#Region "Check Mysql Service"

    Public Shared Function IsMySQLServiceRunning() As Boolean
        Dim serviceName As String = "mysqld.exe"
        Dim serviceController As ServiceController = New ServiceController(serviceName)
        Try
            Dim processName As String = "mysqld"
            Dim processes() As Process = Process.GetProcessesByName(processName)
            If processes.Length > 0 Then
                Console.WriteLine("MySQL server (mysqld.exe) is running.")
                Return True
            Else
                Console.WriteLine("MySQL server (mysqld.exe) is not running.")
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine("Error IsMySQLServiceRunning : " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Sub StartMySQLService()
        Try
            Dim xamppDirectory As String = "d:\xampp"
            Dim batchFile As String = "mysql_start.bat"
            Dim batchFilePath As String = System.IO.Path.Combine(xamppDirectory, batchFile)

            If System.IO.File.Exists(batchFilePath) Then
                Dim processInfo As ProcessStartInfo = New ProcessStartInfo()
                processInfo.FileName = "cmd.exe"
                processInfo.Arguments = "/C " & batchFilePath
                processInfo.UseShellExecute = False ' Required for running cmd.exe 
                Dim process As Process = Process.Start(processInfo)
                Console.WriteLine("Starting MySQL service...")
                ' Check if the process is still running
                If Not process.HasExited Then
                    ' The process is still running, so assume the service is started
                    Console.WriteLine("MySQL service started successfully.")
                Else
                    ' The process has exited, check the exit code if needed
                    If process.ExitCode = 0 Then
                        Console.WriteLine("MySQL service started successfully.")
                    Else
                        Console.WriteLine("Failed to start MySQL service.")
                    End If
                End If
            Else
                Console.WriteLine("The mysql_start.bat batch file does not exist in the XAMPP directory.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
#End Region

    Public Sub New(server As String, database As String, username As String, password As String)
        Me.ConnectionString = $"Server={server};Database={database};User ID={username};Password={password};"
        If TestConnection(ConnectionString) = False Then
            MessageBox.Show("Error TestConnection failed !!!")
        End If
        'Me.Connection = New MySqlConnection(ConnectionString)
    End Sub

#Region "MySQl Connection"
    Public Function TestConnection(connectionString As String) As Boolean
        Dim isMySQLRunning As Boolean = IsMySQLServiceRunning()
        If Not isMySQLRunning Then
            ' MySQL service is not running, attempt to start it
            StartMySQLService()
        End If

        Dim connection As MySqlConnection = New MySqlConnection(connectionString)
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                Console.WriteLine("Connection successful!")
                Return True
            Else
                Console.WriteLine("Connection failed!")
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine("Error TestConnection: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ConnectToMySQL() As MySqlConnection
        Dim connection As MySqlConnection = New MySqlConnection(ConnectionString)
        Return connection
    End Function
#End Region

    Public Function CheckDatabaseExists(databaseName As String) As Boolean
        Dim connection As MySqlConnection = ConnectToMySQL()
        Dim databaseExists As Boolean = False

        If connection IsNot Nothing Then
            Try
                connection.Open()

                Dim checkQuery As String = $"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{databaseName}';"

                Using command As New MySqlCommand(checkQuery, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        databaseExists = True
                    End If
                End Using

            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If

        Return databaseExists
    End Function

    Public Function TableExists(tableName As String) As Boolean
        Try
            Using connection As New MySqlConnection(ConnectionString)
                connection.Open()
                Dim sqlQuery As String = $"SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = @DatabaseName AND TABLE_NAME = @TableName"
                Using cmd As New MySqlCommand(sqlQuery, connection)
                    cmd.Parameters.AddWithValue("@DatabaseName", connection.Database)
                    cmd.Parameters.AddWithValue("@TableName", tableName)
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return result > 0
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine("Error checking table: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ColumnExists(tableName As String, columnName As String) As Boolean
        Dim sqlQuery As String = $"SHOW COLUMNS FROM {tableName} WHERE Field = @ColumnName"
        Using connection As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(sqlQuery, connection)
                cmd.Parameters.AddWithValue("@ColumnName", columnName)
                connection.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Return reader.HasRows
                End Using
            End Using
        End Using
    End Function


    Public Function ExecuteNonQuery(query As String) As Integer
        Dim connection As MySqlConnection = ConnectToMySQL()
        If connection IsNot Nothing Then
            Try
                Using command As New MySqlCommand(query, connection)
                    Try
                        connection.Open()
                        Return command.ExecuteNonQuery()
                    Catch ex As Exception
                        Console.WriteLine("Error executing query: " & ex.Message)
                        Return -1
                    End Try
                End Using
                Console.WriteLine("New database and table created successfully.")

            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
                Return -1
            Finally
                connection.Close()
            End Try
        Else
            Return -1
        End If
    End Function


    Public Sub CreateDatabase(database_name As String)
        Dim connection As MySqlConnection = ConnectToMySQL()

        If connection IsNot Nothing Then
            Try
                connection.Open()
                ' Create a new database
                Dim createDatabaseQuery As String = $"CREATE DATABASE IF NOT EXISTS {database_name};"
                Dim createDatabaseCommand As New MySqlCommand(createDatabaseQuery, connection)
                createDatabaseCommand.ExecuteNonQuery()

                ' Use the new database
                Dim useDatabaseQuery As String = $"USE {database_name};"
                Dim useDatabaseCommand As New MySqlCommand(useDatabaseQuery, connection)
                useDatabaseCommand.ExecuteNonQuery()
                Console.WriteLine("New database and table created successfully.")

            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Public Sub CreateTable(tableName As String, columns As Dictionary(Of String, String))
        Dim columnDefinitions As String = String.Join(", ", columns.Select(Function(column) $"{column.Key} {column.Value}"))
        Dim sqlQuery As String = $"CREATE TABLE IF NOT EXISTS {tableName} ({columnDefinitions})"
        ExecuteNonQuery(sqlQuery)
    End Sub

    Public Sub CheckColumnsAndAdd(tableName As String, columns As Dictionary(Of String, String))
        Try
            Using connection As New MySqlConnection(ConnectionString)
                connection.Open()
                If Not TableExists(tableName) Then
                    Console.WriteLine($"Table '{tableName}' does not exist.")
                    Return
                End If
                Dim existingColumns As New List(Of String)
                For Each column In columns
                    If ColumnExists(tableName, column.Key) Then
                        existingColumns.Add(column.Key)
                        Console.WriteLine($"Column '{column.Key}' already exists in table '{tableName}'.")
                    Else
                        ' Add the new column to the table
                        Dim sqlQuery As String = $"ALTER TABLE {tableName} ADD COLUMN {column.Key} {column.Value}"
                        Using cmd As New MySqlCommand(sqlQuery, connection)
                            cmd.ExecuteNonQuery()
                        End Using

                        Console.WriteLine($"Column '{column.Key}' added to table '{tableName}' successfully.")
                    End If
                Next
                ' Check if there are columns missing in the table
                Dim missingColumns = columns.Keys.Except(existingColumns)
                For Each missingColumn In missingColumns
                    Console.WriteLine($"Column '{missingColumn}' is missing in table '{tableName}'.")
                    ' You can choose to add the missing columns here if needed.
                Next
                connection.Close()
            End Using

        Catch ex As Exception
            Console.WriteLine("Error checking columns and adding: " & ex.Message)
        End Try
    End Sub
#Region "View"
    Private Function CheckViewExist(viewName As String) As Boolean
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM information_schema.views WHERE table_name = @viewName", conn)
            cmd.Parameters.AddWithValue("@viewName", viewName)
            Dim count As Object = cmd.ExecuteScalar()
            conn.Close()
            If count IsNot Nothing AndAlso Not IsDBNull(count) AndAlso Convert.ToInt32(count) > 0 Then
                ' The view exists
                Return True
            Else
                ' The view does not exist
                Return False
            End If
        End Using
    End Function

    Public Function CreateView(databaseName As String, viewName As String, viewDefinition As String) As Boolean
        If CheckViewExist(viewName) Then
            Dim connection As MySqlConnection = ConnectToMySQL()
            If connection IsNot Nothing Then
                Try
                    connection.Open()
                    Dim createViewQuery As String = $"CREATE VIEW {databaseName}.{viewName} AS {vbNewLine}{viewDefinition};"
                    Using command As New MySqlCommand(createViewQuery, connection)
                        command.ExecuteNonQuery()
                    End Using
                    Console.WriteLine($"View '{viewName}' created successfully.")
                    Return True

                Catch ex As Exception
                    ' Handle the exception if any error occurs
                    Console.WriteLine("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
            Return False
        Else
            Return False
        End If
    End Function
#End Region

#Region "Stored Procedure"
    Public Function CheckStoredProcedure(procedureName As String, Optional routine_type As String = "PROCEDURE") As Boolean
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"SELECT COUNT(*) FROM information_schema.routines WHERE routine_name = '{procedureName}' AND routine_type = '{routine_type}'", conn)

            Dim count As Object = cmd.ExecuteScalar()
            If count IsNot Nothing AndAlso Not IsDBNull(count) AndAlso Convert.ToInt32(count) > 0 Then
                ' The stored procedure exists
                Return True
            Else
                ' The stored procedure does not exist
                Return False
            End If
            conn.Close()
        End Using
    End Function


    Public Function CreateStoredProcedure(databaseName As String, procedureName As String, procedureDefinition As String) As Boolean
        If CheckStoredProcedure(procedureName) Then
            Dim connection As MySqlConnection = ConnectToMySQL()
            If connection IsNot Nothing Then
                Try
                    connection.Open()
                    Dim createProcedureQuery As String = $"CREATE PROCEDURE {databaseName}.{procedureName} {procedureDefinition};"
                    Using command As New MySqlCommand(createProcedureQuery, connection)
                        command.ExecuteNonQuery()
                    End Using
                    Console.WriteLine($"Stored procedure '{procedureName}' created successfully.")
                    Return True
                Catch ex As Exception
                    ' Handle the exception if any error occurs
                    Console.WriteLine("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
            Return False
        Else
            Return False
        End If


    End Function

#End Region

#Region "Where Logical Operator"

    Public Class WhereCondition
        Public Property ColumnName As String
        Public Property Value As Object
        Public Property OperatorB As SqlOperator
        Public Property LogicalOperator As WhereLogicalOperator

        ' Constructor for conditions with a specified operator
        Public Sub New(columnName As String, value As Object, [operator] As SqlOperator, logicalOperator As WhereLogicalOperator)
            Me.ColumnName = columnName
            Me.Value = value
            Me.OperatorB = [operator]
            Me.LogicalOperator = logicalOperator
        End Sub
    End Class

    Public Enum WhereLogicalOperator
        None
        [And]
        [Or]
    End Enum

    Public Enum SqlOperator
        EqualTo
        NotEqualTo
        LessThan
        GreaterThan
        LessThanOrEqualTo
        GreaterThanOrEqualTo
        ' Add more operators as needed
    End Enum

    ' Helper function to map SqlOperator enum to SQL operators
    Private Function GetSqlOperator(operatorEnum As SqlOperator) As String
        Select Case operatorEnum
            Case SqlOperator.EqualTo
                Return "="
            Case SqlOperator.NotEqualTo
                Return "<>"
            Case SqlOperator.LessThan
                Return "<"
            Case SqlOperator.GreaterThan
                Return ">"
            Case SqlOperator.LessThanOrEqualTo
                Return "<="
            Case SqlOperator.GreaterThanOrEqualTo
                Return ">="
            Case Else
                Return "="
        End Select
    End Function

#End Region

#Region "Select Data"

    Public Function SelectData(tableName As String, whereConditions As List(Of WhereCondition)) As DataTable
        Dim connection As MySqlConnection = ConnectToMySQL()
        Dim dataTable As New DataTable()
        If connection IsNot Nothing Then
            Try
                connection.Open()
                ' Build the SELECT query dynamically
                Dim sb As New StringBuilder()
                sb.Append($"SELECT * FROM {tableName}")
                If whereConditions.Count > 0 Then
                    sb.Append(" WHERE ")
                    ' Iterate through the list of conditions to build the WHERE clause
                    For Each condition As WhereCondition In whereConditions
                        If sb.Length > 0 AndAlso condition.LogicalOperator <> WhereLogicalOperator.None Then
                            sb.Append($" {condition.LogicalOperator.ToString().ToUpper()} ")
                        End If
                        sb.Append($"({condition.ColumnName} {GetSqlOperator(condition.OperatorB)} '{condition.Value}')")
                    Next
                End If
                Dim selectQuery As String = sb.ToString()
                Using adapter As New MySqlDataAdapter(selectQuery, connection)
                    adapter.Fill(dataTable)
                End Using

            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
        Return dataTable
    End Function


    Public Function ExecuteDataTable(query As String) As DataTable
        Dim connection As MySqlConnection = ConnectToMySQL()
        Dim dataTable As New DataTable()
        If connection IsNot Nothing Then
            Try
                connection.Open()
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.Fill(dataTable)
                End Using

            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
        Return dataTable
    End Function

#End Region

#Region "Insert Data"
    Public Sub InsertData(tableName As String, values As Dictionary(Of String, Object))
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As MySqlCommand = conn.CreateCommand()
            Dim columns As String = String.Join(", ", values.Keys)
            Dim placeholders As String = String.Join(", ", values.Keys.Select(Function(x) "@" & x))
            cmd.CommandText = $"INSERT INTO {tableName} ({columns}) VALUES ({placeholders});"

            For Each kvp In values
                cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
            Next

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub InsertDataFromDataTable(tableName As String, dataTable As DataTable)
        Dim connection As MySqlConnection = ConnectToMySQL()
        If connection IsNot Nothing Then
            Try
                connection.Open()
                For Each row As DataRow In dataTable.Rows
                    Dim columns As New List(Of String)()
                    Dim values As New List(Of String)()

                    For Each column As DataColumn In dataTable.Columns
                        columns.Add(column.ColumnName)
                        values.Add($"'{row(column)}'")
                    Next

                    Dim insertQuery As String = $"INSERT INTO {tableName} ({String.Join(", ", columns)}) VALUES ({String.Join(", ", values)});"

                    Using command As New MySqlCommand(insertQuery, connection)
                        command.ExecuteNonQuery()
                    End Using
                Next

                Console.WriteLine("Data inserted successfully.")

            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
#End Region

#Region "Update And Delete"

    Public Sub UpdateData(tableName As String, updateValues As Dictionary(Of String, Object), whereConditions As List(Of WhereCondition))
        Dim connection As MySqlConnection = ConnectToMySQL()
        If connection IsNot Nothing Then
            Try
                connection.Open()
                ' Build the UPDATE query dynamically
                Dim sb As New StringBuilder()
                sb.Append($"UPDATE {tableName} SET ")
                ' Iterate through the update values to build the SET clause
                Dim updateColumns As List(Of String) = updateValues.Select(Function(column) $"{column.Key} = '{column.Value}'").ToList()
                sb.Append(String.Join(", ", updateColumns))
                If whereConditions.Count > 0 Then
                    sb.Append(" WHERE ")

                    ' Iterate through the list of conditions to build the WHERE clause
                    For Each condition As WhereCondition In whereConditions
                        If sb.Length > 0 AndAlso condition.LogicalOperator <> WhereLogicalOperator.None Then
                            sb.Append($" {condition.LogicalOperator.ToString().ToUpper()} ")
                        End If
                        sb.Append($"({condition.ColumnName} {GetSqlOperator(condition.OperatorB)} '{condition.Value}')")
                    Next
                End If
                Dim updateQuery As String = sb.ToString()
                Using command As New MySqlCommand(updateQuery, connection)
                    command.ExecuteNonQuery()
                End Using
                Console.WriteLine("Data updated successfully.")
            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
    Public Sub DeleteData(tableName As String, whereConditions As List(Of WhereCondition))
        Dim connection As MySqlConnection = ConnectToMySQL()
        If connection IsNot Nothing Then
            Try
                connection.Open()
                ' Build the DELETE query dynamically
                Dim sb As New StringBuilder()
                sb.Append($"DELETE FROM {tableName}")
                If whereConditions.Count > 0 Then
                    sb.Append(" WHERE ")
                    ' Iterate through the list of conditions to build the WHERE clause
                    For Each condition As WhereCondition In whereConditions
                        If sb.Length > 0 AndAlso condition.LogicalOperator <> WhereLogicalOperator.None Then
                            sb.Append($" {condition.LogicalOperator.ToString().ToUpper()} ")
                        End If
                        sb.Append($"({condition.ColumnName} {GetSqlOperator(condition.OperatorB)} '{condition.Value}')")
                    Next
                End If
                Dim deleteQuery As String = sb.ToString()
                Using command As New MySqlCommand(deleteQuery, connection)
                    command.ExecuteNonQuery()
                End Using
                Console.WriteLine("Data deleted successfully.")
            Catch ex As Exception
                ' Handle the exception if any error occurs
                Console.WriteLine("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
#End Region

    Public Sub TruncateTable(tableName As String)
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"TRUNCATE TABLE {tableName}", conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    'Public Sub CloseConnection()
    '    If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
    '        Connection.Close()
    '    End If
    'End Sub

    'Public Sub Test_Class()
    '    Dim server As String = "your_mysql_server"
    '    Dim database As String = "your_database"
    '    Dim username As String = "your_username"
    '    Dim password As String = "your_password"
    '    Dim dbHelper As New MySQLHelper(server, database, username, password)

    '    ' Create a table
    '    Dim columns As New Dictionary(Of String, String)()
    '    columns.Add("ID", "INT PRIMARY KEY AUTO_INCREMENT")
    '    columns.Add("Name", "VARCHAR(255)")
    '    dbHelper.CreateTable("YourTable", columns)

    '    ' Insert data
    '    Dim values As New Dictionary(Of String, Object)()
    '    values.Add("Name", "John Doe")
    '    dbHelper.InsertData("YourTable", values)

    '    ' Select data
    '    Dim dataTable As DataTable = dbHelper.SelectData("YourTable")
    '    dbHelper.ViewData(dataTable)

    '    ' Update data
    '    Dim updateValues As New Dictionary(Of String, Object)()
    '    updateValues.Add("Name", "Jane Smith")
    '    dbHelper.UpdateData("YourTable", updateValues, "ID = 1")

    '    ' Delete data
    '    dbHelper.DeleteData("YourTable", "ID = 1")

    '    ' Truncate table
    '    dbHelper.TruncateTable("YourTable")

    '    ' Close the connection when you're done
    '    'dbHelper.CloseConnection()

    'End Sub
End Class
