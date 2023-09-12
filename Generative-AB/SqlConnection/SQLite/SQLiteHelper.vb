Imports System.Data.SQLite

Public Class SQLiteHelper
    Private ConnectionString As String
    Private Connection As SQLiteConnection

    Public Sub New(databasePath As String)
        ' Check if the file already exists; if not, create it
        If Not System.IO.File.Exists(databasePath) Then
            SQLiteConnection.CreateFile(databasePath)
        End If
        Me.ConnectionString = $"Data Source={databasePath};Version=3;"
        Me.Connection = New SQLiteConnection(ConnectionString)
    End Sub
    Public Function ConnectToSQLite() As SQLiteConnection
        Try 
            Dim connection As New SQLiteConnection(connectionString)
            connection.Open()
            Return connection
        Catch ex As Exception
            ' Handle any exceptions here
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing ' Return null if connection fails
        End Try
    End Function
    Public Sub CreateTable(tableName As String, columns As Dictionary(Of String, String))
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim cmd As SQLiteCommand = conn.CreateCommand()
            Dim sb As New System.Text.StringBuilder()
            sb.Append($"CREATE TABLE IF NOT EXISTS {tableName} (")
            For Each column In columns
                sb.Append($"{column.Key} {column.Value}, ")
            Next
            sb.Length -= 2 ' Remove the trailing comma and space
            sb.Append(");")
            cmd.CommandText = sb.ToString()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        CheckColumnsAndAdd(tableName, columns)
    End Sub

    Public Sub CheckColumnsAndAdd(tableName As String, columnsToCheck As Dictionary(Of String, String))
        ' Check if the columns exist
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            ' Execute PRAGMA table_info to retrieve column names
            Dim query As String = $"PRAGMA table_info({tableName});"
            Using cmd As New SQLiteCommand(query, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim existingColumns As New List(Of String)()
                    While reader.Read()
                        Dim columnName As String = reader("name").ToString()
                        existingColumns.Add(columnName)
                    End While
                    ' Add any missing columns
                    For Each columnToCheck In columnsToCheck
                        Dim columnName As String = columnToCheck.Key
                        Dim columnDataType As String = columnToCheck.Value

                        If Not existingColumns.Contains(columnName) Then
                            ' Execute ALTER TABLE to add missing column
                            Dim alterQuery As String = $"ALTER TABLE {tableName} ADD COLUMN {columnName} {columnDataType};"
                            Using alterCmd As New SQLiteCommand(alterQuery, conn)
                                alterCmd.ExecuteNonQuery()
                                Console.WriteLine($"Added missing column: {columnName} ({columnDataType})")
                            End Using
                        End If
                    Next
                End Using
            End Using
            conn.Close()
        End Using
    End Sub


    Public Function SelectData(tableName As String, Optional condition As String = "", Optional query_SELECT As String = "") As DataTable
        Dim dt As New DataTable()
        Try
            ' Open a new connection
            Using connection As New SQLiteConnection(ConnectionString) ' Replace ConnectionString with your actual connection string
                connection.Open()

                If Not String.IsNullOrEmpty(query_SELECT) Then
                    query_SELECT = $"{query_SELECT}"
                Else
                    query_SELECT = $" * "
                End If
                Dim query As String = $"SELECT {query_SELECT} FROM {tableName}"
                If Not String.IsNullOrEmpty(condition) Then
                    query &= $" WHERE {condition}"
                End If

                Using cmd As New SQLiteCommand(query, connection)
                    Dim adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                connection.Close()
                Return dt
            End Using
        Catch ex As Exception
            ' Handle any exceptions here
            Console.WriteLine("Error: " & ex.Message)
            Return dt ' Return null or an empty DataTable in case of an error
        End Try
    End Function

    Public Function GetRowCount(tableName As String, Optional condition As String = "") As Integer
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim rowCount As Integer = 0
            Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE {condition};"
            Using cmd As New SQLiteCommand(query, conn)
                rowCount = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            conn.Close()
            Return rowCount
        End Using
    End Function

    Public Sub InsertData(tableName As String, values As Dictionary(Of String, Object))
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim cmd As SQLiteCommand = conn.CreateCommand()
            Dim columns As String = String.Join(", ", values.Keys)
            Dim placeholders As String = String.Join(", ", values.Keys.Select(Function(x) "@" & x))
            cmd.CommandText = $"INSERT INTO {tableName} ({columns}) VALUES ({placeholders});"
            For Each kvp In values
                cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
            Next
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Public Sub UpdateData(tableName As String, values As Dictionary(Of String, Object), condition As String)
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim cmd As SQLiteCommand = conn.CreateCommand()
            Dim setClause As String = String.Join(", ", values.Select(Function(x) $"{x.Key} = @{x.Key}"))
            cmd.CommandText = $"UPDATE {tableName} SET {setClause} WHERE {condition};"
            For Each kvp In values
                cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
            Next
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DeleteData(tableName As String, condition As String)
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand($"DELETE FROM {tableName} WHERE {condition}", conn)
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
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand($"DELETE FROM {tableName}", conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub CloseConnection()
        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub

    Public Function ExecuteQuery(query As String) As DataTable
        Dim resultTable As New DataTable()
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand(query, conn)
            Try
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(resultTable)
                End Using
            Catch ex As Exception
                ' Handle any exceptions that may occur during execution.
                Console.WriteLine("Error executing query: " & ex.Message)
            End Try
        End Using

        Return resultTable
    End Function

    Public Sub Test_Class()
        Dim dbPath As String = "your_database_path.sqlite"
        Dim dbHelper As New SQLiteHelper(dbPath)

        ' Create a table
        Dim columns As New Dictionary(Of String, String)()
        columns.Add("ID", "INTEGER PRIMARY KEY AUTOINCREMENT")
        columns.Add("Name", "TEXT")
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
