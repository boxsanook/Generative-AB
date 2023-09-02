Imports System.Data.SQLite

Module SQLiteTable
    Dim dbPath As String = "your_database_path.sqlite"
    Dim dbHelper As New SQLiteHelper(dbPath)


    Public Sub Create_master_keywords()
        ' Define the columns for the Keywords table
        Dim keywordsColumns As New Dictionary(Of String, String)()
        keywordsColumns.Add("id", "INTEGER PRIMARY KEY AUTOINCREMENT")
        keywordsColumns.Add("originKeywords", "TEXT")
        keywordsColumns.Add("keywords", "TEXT")
        keywordsColumns.Add("origin_tag", "TEXT")
        keywordsColumns.Add("type", "TEXT")
        ' Create the Keywords table using the CreateTable method
        dbHelper.CreateTable("master_keywords", keywordsColumns)
    End Sub
    Public Sub InsertOrUpdateMasterKeyword(originKeywords As String, keywords As String, origin_tag As String, type As String)
        Using conn As New SQLiteConnection(dbPath)
            conn.Open()
            Using trans As SQLiteTransaction = conn.BeginTransaction()
                Dim cmd As New SQLiteCommand(conn)
                cmd.Transaction = trans

                ' Check if the record exists
                cmd.CommandText = "SELECT COUNT(*) FROM master_keywords WHERE " &
                    "originKeywords = @originKeywords AND " &
                    "keywords = @keywords AND " &
                    "origin_tag = @origin_tag AND " &
                    "type = @type"
                cmd.Parameters.AddWithValue("@originKeywords", originKeywords)
                cmd.Parameters.AddWithValue("@keywords", keywords)
                cmd.Parameters.AddWithValue("@origin_tag", origin_tag)
                cmd.Parameters.AddWithValue("@type", type)

                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count = 0 Then
                    ' Record doesn't exist, insert it
                    cmd.CommandText = "INSERT INTO master_keywords (originKeywords, keywords, origin_tag, type) " &
                        "VALUES (@originKeywords, @keywords, @origin_tag, @type)"
                    cmd.ExecuteNonQuery()
                End If

                trans.Commit()
            End Using
        End Using
    End Sub
    Public Sub Create_ai_image_type()
        ' Define the columns for the image_type table
        Dim imageTypeColumns As New Dictionary(Of String, String)()
        imageTypeColumns.Add("id", "INTEGER PRIMARY KEY AUTOINCREMENT")
        imageTypeColumns.Add("style_name", "TEXT")
        imageTypeColumns.Add("image_type", "TEXT")
        imageTypeColumns.Add("jsonPayload", "TEXT") ' You can use TEXT for JSON data

        ' Create the image_type table using the CreateTable method
        dbHelper.CreateTable("ai_image_type", imageTypeColumns)
    End Sub

End Module
