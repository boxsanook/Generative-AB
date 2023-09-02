Imports MySql.Data.MySqlClient

Module MySQLTable
    Dim server As String = "127.0.0.1"
    Dim database As String = "your_database"
    Dim username As String = "your_username"
    Dim password As String = "your_password"
    Dim dbHelper As New MySQLHelper(server, database, username, password)

    Public Sub Create_master_keywords()
        Dim keywordsColumns As New Dictionary(Of String, String)()
        keywordsColumns.Add("id", "INT AUTO_INCREMENT PRIMARY KEY")
        keywordsColumns.Add("originKeywords", "VARCHAR(255)")
        keywordsColumns.Add("keywords", "VARCHAR(255)")
        keywordsColumns.Add("origin_tag", "VARCHAR(255)")
        keywordsColumns.Add("type", "VARCHAR(255)")
        dbHelper.CreateTable("master_keywords", keywordsColumns)
        If dbHelper.PROCEDURE_info("InsertMasterKeywordProcedure") Then
            CreateInsertMasterKeywordProcedure()
        End If
    End Sub

    Public Sub CreateInsertMasterKeywordProcedure()
        Using conn As New MySqlConnection(dbHelper.ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand()
            ' Set a custom delimiter for defining the procedure
            cmd.Connection = conn
            cmd.CommandText = "DELIMITER $$" & vbCrLf &
                              "CREATE PROCEDURE InsertMasterKeywordProcedure(" & vbCrLf &
                              "    IN p_originKeywords VARCHAR(255)," & vbCrLf &
                              "    IN p_keywords VARCHAR(255)," & vbCrLf &
                              "    IN p_origin_tag VARCHAR(255)," & vbCrLf &
                              "    IN p_type VARCHAR(255)" & vbCrLf &
                              ")" & vbCrLf &
                              "BEGIN" & vbCrLf &
                              "    DECLARE keywordCount INT;" & vbCrLf &
                              "    SET keywordCount = (SELECT COUNT(*) FROM master_keywords WHERE " & vbCrLf &
                              "        originKeywords = p_originKeywords AND " & vbCrLf &
                              "        keywords = p_keywords AND  );" & vbCrLf &
                              "    IF keywordCount = 0 THEN" & vbCrLf &
                              "        INSERT INTO master_keywords (originKeywords, keywords, origin_tag, type)" & vbCrLf &
                              "        VALUES (p_originKeywords, p_keywords, p_origin_tag, p_type);" & vbCrLf &
                              "    END IF;" & vbCrLf &
                              "END$$"

            cmd.ExecuteNonQuery()
            ' Reset the delimiter to the default
            cmd.CommandText = "DELIMITER ;"
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub InsertMasterKeyword(dataTable As DataTable)
        Using conn As New MySqlConnection(dbHelper.ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("InsertMasterKeywordProcedure", conn)
            cmd.CommandType = CommandType.StoredProcedure
            ' Define the parameters
            cmd.Parameters.AddWithValue("@p_originKeywords", "")
            cmd.Parameters.AddWithValue("@p_keywords", "")
            cmd.Parameters.AddWithValue("@p_origin_tag", "")
            cmd.Parameters.AddWithValue("@p_type", "")

            ' Iterate through the rows of the DataTable
            For Each row As DataRow In dataTable.Rows
                cmd.Parameters("@p_originKeywords").Value = row("originKeywords")
                cmd.Parameters("@p_keywords").Value = row("keywords")
                cmd.Parameters("@p_origin_tag").Value = row("origin_tag")
                cmd.Parameters("@p_type").Value = row("type")
                ' Execute the stored procedure for each row
                cmd.ExecuteNonQuery()
            Next
        End Using
    End Sub



    Public Sub Create_ai_image_type()
        ' Define the columns for the image_type table
        Dim imageTypeColumns As New Dictionary(Of String, String)()
        imageTypeColumns.Add("id", "INT AUTO_INCREMENT PRIMARY KEY")
        imageTypeColumns.Add("style_name", "VARCHAR(255)")
        imageTypeColumns.Add("image_type", "VARCHAR(255)")
        imageTypeColumns.Add("jsonPayload", "TEXT") ' You can use TEXT for JSON data 
        ' Create the image_type table using the CreateTable method
        dbHelper.CreateTable("ai_image_type", imageTypeColumns)
        If dbHelper.PROCEDURE_info("InsertAIImageTypeProcedure") Then
            CreateInsertMasterKeywordProcedure()
        End If
    End Sub
    Public Sub CreateInsertAIImageTypeProcedure()
        Using conn As New MySqlConnection(dbHelper.ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand()

            ' Set a custom delimiter for defining the procedure
            cmd.Connection = conn
            cmd.CommandText = "DELIMITER $$" & vbCrLf &
                              "CREATE PROCEDURE InsertAIImageTypeProcedure(" & vbCrLf &
                              "    IN p_style_name VARCHAR(255)," & vbCrLf &
                              "    IN p_image_type VARCHAR(255)," & vbCrLf &
                              "    IN p_jsonPayload TEXT" & vbCrLf &
                              ")" & vbCrLf &
                              "BEGIN" & vbCrLf &
                              "    DECLARE keywordCount INT;" & vbCrLf &
                              "    SET keywordCount = (SELECT COUNT(*) FROM ai_image_type WHERE " & vbCrLf &
                              "        style_name = p_style_name AND " & vbCrLf &
                              "        image_type = p_image_type );" & vbCrLf &
                              "    IF keywordCount = 0 THEN" & vbCrLf &
                              "      INSERT INTO ai_image_type (style_name, image_type, jsonPayload)" & vbCrLf &
                              "      VALUES (p_style_name, p_image_type, p_jsonPayload);" & vbCrLf &
                              "    END IF;" & vbCrLf &
                              "END$$"
            cmd.ExecuteNonQuery()
            ' Reset the delimiter to the default
            cmd.CommandText = "DELIMITER ;"
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub InsertAIImageType(styleName As String, imageType As String, jsonPayload As String)
        Using conn As New MySqlConnection(dbHelper.ConnectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("InsertAIImageTypeProcedure", conn)
            cmd.CommandType = CommandType.StoredProcedure
            ' Define the parameters
            cmd.Parameters.AddWithValue("@p_style_name", styleName)
            cmd.Parameters.AddWithValue("@p_image_type", imageType)
            cmd.Parameters.AddWithValue("@p_jsonPayload", jsonPayload)
            ' Execute the stored procedure
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Module
