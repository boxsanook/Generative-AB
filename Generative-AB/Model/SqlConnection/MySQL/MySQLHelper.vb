Imports MySql.Data.MySqlClient

Public Class MySQLHelper
    Public ConnectionString As String
    Private Connection As MySqlConnection

    Public Sub New(server As String, database As String, username As String, password As String)
        Me.ConnectionString = $"Server={server};Database={database};User ID={username};Password={password};"
        Me.Connection = New MySqlConnection(ConnectionString)
    End Sub

    Public Sub CreateTable(tableName As String, columns As Dictionary(Of String, String))
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As MySqlCommand = conn.CreateCommand()
            Dim sb As New System.Text.StringBuilder()

            sb.Append($"CREATE TABLE IF NOT EXISTS {tableName} (")
            For Each column In columns
                sb.Append($"{column.Key} {column.Value}, ")
            Next
            sb.Length -= 2 ' Remove the trailing comma and space
            sb.Append(");")

            cmd.CommandText = sb.ToString()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Function PROCEDURE_info(routine_name As String, Optional routine_type As String = "PROCEDURE") As Boolean
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"SELECT COUNT(*) FROM information_schema.routines WHERE routine_name = '{routine_name}' AND routine_type = '{routine_type}'", conn)

            Dim count As Object = cmd.ExecuteScalar()
            If count IsNot Nothing AndAlso Not IsDBNull(count) AndAlso Convert.ToInt32(count) > 0 Then
                ' The stored procedure exists
                Return True
            Else
                ' The stored procedure does not exist
                Return False
            End If
        End Using
    End Function

    Public Function SelectData(tableName As String, Optional condition As String = "") As DataTable
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"SELECT * FROM {tableName} {condition}", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Return dt
        End Using
    End Function

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

    Public Sub UpdateData(tableName As String, values As Dictionary(Of String, Object), condition As String)
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As MySqlCommand = conn.CreateCommand()
            Dim setClause As String = String.Join(", ", values.Select(Function(x) $"{x.Key} = @{x.Key}"))
            cmd.CommandText = $"UPDATE {tableName} SET {setClause} WHERE {condition};"

            For Each kvp In values
                cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
            Next

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DeleteData(tableName As String, condition As String)
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"DELETE FROM {tableName} WHERE {condition}", conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub ViewData(dataTable As DataTable)
        For Each row As DataRow In dataTable.Rows
            For Each col As DataColumn In dataTable.Columns
                Console.Write($"{col.ColumnName}: {row(col)} | ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub TruncateTable(tableName As String)
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand($"TRUNCATE TABLE {tableName}", conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Function ExecuteQuery(query As String) As DataTable
        Dim resultTable As New DataTable()

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)

            Try
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(resultTable)
                End Using
            Catch ex As Exception
                ' Handle any exceptions that may occur during execution.
                Console.WriteLine("Error executing query: " & ex.Message)
            End Try
        End Using

        Return resultTable
    End Function
    Public Sub CloseConnection()
        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub


    Public Sub Test_Class()
        Dim server As String = "your_mysql_server"
        Dim database As String = "your_database"
        Dim username As String = "your_username"
        Dim password As String = "your_password"
        Dim dbHelper As New MySQLHelper(server, database, username, password)

        ' Create a table
        Dim columns As New Dictionary(Of String, String)()
        columns.Add("ID", "INT PRIMARY KEY AUTO_INCREMENT")
        columns.Add("Name", "VARCHAR(255)")
        dbHelper.CreateTable("YourTable", columns)

        ' Insert data
        Dim values As New Dictionary(Of String, Object)()
        values.Add("Name", "John Doe")
        dbHelper.InsertData("YourTable", values)

        ' Select data
        Dim dataTable As DataTable = dbHelper.SelectData("YourTable")
        dbHelper.ViewData(dataTable)

        ' Update data
        Dim updateValues As New Dictionary(Of String, Object)()
        updateValues.Add("Name", "Jane Smith")
        dbHelper.UpdateData("YourTable", updateValues, "ID = 1")

        ' Delete data
        dbHelper.DeleteData("YourTable", "ID = 1")

        ' Truncate table
        dbHelper.TruncateTable("YourTable")

        ' Close the connection when you're done
        dbHelper.CloseConnection()

    End Sub
End Class
