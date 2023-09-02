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
        End Using
    End Sub

    Public Function SelectData(tableName As String, Optional condition As String = "") As DataTable
        Using conn As New SQLiteConnection(ConnectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand($"SELECT * FROM {tableName} {condition}", conn)
            Dim adapter As New SQLiteDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Return dt
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
