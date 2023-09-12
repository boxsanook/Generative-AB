Imports System.Data.SQLite

Class SQLiteTable
    Dim dbPath As String = ModuleSQLconfig.Set_mysqldumpPath & ModuleSQLconfig.Set_txtDatabase

    Public Sub New(dbPathA As String)
        Me.dbPath = dbPathA
    End Sub
    Public Sub NewTable()
        Create_master_keywords()
        Create_air_history()
        Create_air_image_type()
        Create_image_description()
        Create_prompt_image()
        Create_image_keyword()
    End Sub
    Public Sub Create_master_keywords()
        Dim dbHelper As New SQLiteHelper(dbPath)
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
    Public Sub Create_air_history()
        Dim dbHelper As New SQLiteHelper(dbPath)
        Dim TableName As String = "air_history"
        ' Define the columns for the Keywords table
        Dim keywordsColumns As New Dictionary(Of String, String)()
        keywordsColumns.Add("id", "INTEGER PRIMARY KEY AUTOINCREMENT")
        keywordsColumns.Add("image_id", "TEXT")
        keywordsColumns.Add("prompt", "TEXT")
        keywordsColumns.Add("likes", "INTEGER")
        keywordsColumns.Add("dislikes", "INTEGER")
        keywordsColumns.Add("image_type", "TEXT")
        keywordsColumns.Add("recraft_id", "TEXT")
        keywordsColumns.Add("width", "INTEGER")
        keywordsColumns.Add("height", "INTEGER")
        ' Create the Keywords table using the CreateTable method
        dbHelper.CreateTable(TableName, keywordsColumns)

    End Sub

    Public Sub Create_air_image_type()
        Dim dbHelper As New SQLiteHelper(dbPath)
        Dim tableName As String = "air_image_type"
        Dim imageTypeColumns As New Dictionary(Of String, String)()
        imageTypeColumns.Add("id", "INTEGER PRIMARY KEY AUTOINCREMENT")
        imageTypeColumns.Add("category", "TEXT")
        imageTypeColumns.Add("style_name", "TEXT")
        imageTypeColumns.Add("image_type", "TEXT")
        imageTypeColumns.Add("jsonPayload", "TEXT") ' You can use TEXT for JSON data 
        imageTypeColumns.Add("status", "BOOLEAN DEFAULT 0")
        ' Create the image_type table using the CreateTable method
        dbHelper.CreateTable(tableName, imageTypeColumns)

        Dim DT As New DataTable
        DT.Columns.Add("category", GetType(String))
        DT.Columns.Add("style_name", GetType(String))
        DT.Columns.Add("image_type", GetType(String))
        DT.Rows.Add("Vector art", "Vector art", "vector_illustration")
        DT.Rows.Add("Vector art", "Line art", "vector_illustration_line_art")
        DT.Rows.Add("Vector art", "Flat 2.0", "vector_illustration_flat_2")
        DT.Rows.Add("Vector art", "Cartoon", "vector_illustration_cartoon")
        DT.Rows.Add("Vector art", "Vector Kawaii", "vector_illustration_kawaii")
        DT.Rows.Add("Vector art", "Linocut", "vector_illustration_linocut")
        DT.Rows.Add("Vector art", "Engraving", "vector_illustration_engraving")
        DT.Rows.Add("Vector art", "Doodle Line art", "vector_illustration_doodle_line_art")
        DT.Rows.Add("Illustration", "Illustration", "digital_illustration")
        DT.Rows.Add("Illustration", "Hand-drawn", "digital_illustration_hand_drawn")
        DT.Rows.Add("Illustration", "Glow", "digital_illustration_glow")
        DT.Rows.Add("Illustration", "Psychedelic", "digital_illustration_psychedelic")
        DT.Rows.Add("Illustration", "Grain", "digital_illustration_grain")
        DT.Rows.Add("Illustration", "80's", "digital_illustration_80s")
        DT.Rows.Add("Illustration", "Pixel art", "digital_illustration_pixel_art")
        DT.Rows.Add("Illustration", "Watercolor", "digital_illustration_watercolor")
        DT.Rows.Add("Illustration", "Kawaii", "digital_illustration_kawaii")
        DT.Rows.Add("Illustration", "Pencil sketch", "digital_illustration_infantile_sketch")
        DT.Rows.Add("Icon", "Icon", "icon")
        DT.Rows.Add("Icon", "Outline", "icon_outline")
        DT.Rows.Add("Icon", "Pictogram", "pictogram")
        DT.Rows.Add("Icon", "Colored outline", "icon_colored_outline")
        DT.Rows.Add("Icon", "Colored shapes", "icon_colored_shapes")
        DT.Rows.Add("Icon", "Broken line", "icon_broken_line")
        DT.Rows.Add("Icon", "Offset fill", "icon_offset_fill")
        DT.Rows.Add("Icon", "Gradient outline", "icon_outline_gradient")
        DT.Rows.Add("Icon", "Gradient shapes", "icon_colored_shapes_gradient")
        DT.Rows.Add("Icon", "Crosshatched", "icon_uneven_fill")
        DT.Rows.Add("Icon", "Doodle", "icon_doodle_fill")
        DT.Rows.Add("Icon", "Offset doodle", "icon_doodle_fill")
        DT.Rows.Add("3D illustration", "3D render", "digital_illustration_3d")
        DT.Rows.Add("3D illustration", "Plastic 3D", "illustration_3d")
        DT.Rows.Add("Photorealism", "Photorealism", "realistic_image")

        For Each row As DataRow In DT.Rows
            Dim Check As String = $"category='{row("category")}' And image_type ='{row("image_type")}'"
            If dbHelper.GetRowCount(tableName, Check) <= 0 Then
                ' Create a table
                Dim columns As New Dictionary(Of String, Object)()
                columns.Add("category", row("category"))
                columns.Add("style_name", row("style_name"))
                columns.Add("image_type", row("image_type"))
                dbHelper.InsertData(tableName, columns)
            End If
        Next
    End Sub

    Public Sub Create_image_description()
        Dim dbHelper As New SQLiteHelper(dbPath)
        Dim tableName As String = "master_image_description"
        ' Define the columns for the image_description table
        Dim imageTypeColumns As New Dictionary(Of String, String)()
        imageTypeColumns.Add("id", "INTEGER PRIMARY KEY AUTOINCREMENT")
        imageTypeColumns.Add("uniqueId", "TEXT")
        imageTypeColumns.Add("random_seed", "TEXT")
        imageTypeColumns.Add("Filename", "TEXT")
        imageTypeColumns.Add("filePath", "TEXT")
        imageTypeColumns.Add("Image_Name", "TEXT")
        imageTypeColumns.Add("Description", "TEXT")
        imageTypeColumns.Add("Category_1", "TEXT")
        imageTypeColumns.Add("Category_2", "TEXT")
        imageTypeColumns.Add("Category_3", "TEXT")
        imageTypeColumns.Add("keywords", "TEXT")
        imageTypeColumns.Add("prompt_image_id", "INTEGER")
        imageTypeColumns.Add("in_keyword", "TEXT")
        imageTypeColumns.Add("in_sub_keyword", "TEXT")
        imageTypeColumns.Add("in_prompt", "TEXT")

        imageTypeColumns.Add("status", "BOOLEAN DEFAULT 0") ' Add a default value for the "status" column (0 for False)
        imageTypeColumns.Add("with_date", "TIMESTAMP DEFAULT CURRENT_TIMESTAMP") ' Use TIMESTAMP for auto-generating dates
        dbHelper.CreateTable(tableName, imageTypeColumns)
    End Sub


    Public Sub Create_image_keyword()
        Dim dbHelper As New SQLiteHelper(dbPath)
        Dim tableName As String = "master_image_keyword"
        ' Define the columns for the image_description table
        Dim imageTypeColumns As New Dictionary(Of String, String)()
        imageTypeColumns.Add("id", "INTEGER PRIMARY KEY AUTOINCREMENT")
        imageTypeColumns.Add("uniqueId", "TEXT")
        imageTypeColumns.Add("Filename", "TEXT")
        imageTypeColumns.Add("title", "TEXT")
        imageTypeColumns.Add("description", "TEXT")
        imageTypeColumns.Add("keywords", "TEXT")
        imageTypeColumns.Add("status", "BOOLEAN DEFAULT 0") ' Add a default value for the "status" column (0 for False)
        imageTypeColumns.Add("with_date", "TIMESTAMP DEFAULT CURRENT_TIMESTAMP") ' Use TIMESTAMP for auto-generating dates
        dbHelper.CreateTable(tableName, imageTypeColumns)
    End Sub


    Public Sub Create_prompt_image()
        Dim dbHelper As New SQLiteHelper(dbPath)
        Dim tableName As String = "master_prompt_image"
        ' Define the columns for the image_description table
        Dim imageTypeColumns As New Dictionary(Of String, String)()
        imageTypeColumns.Add("id", "INTEGER PRIMARY KEY AUTOINCREMENT")
        imageTypeColumns.Add("keyword", "TEXT")
        imageTypeColumns.Add("sub_keyword", "TEXT")
        imageTypeColumns.Add("prompt", "TEXT")
        imageTypeColumns.Add("prompt_loop", "INTEGER")
        imageTypeColumns.Add("prompt_loop_count", "INTEGER")
        imageTypeColumns.Add("group_id", "TEXT")
        imageTypeColumns.Add("status", "BOOLEAN DEFAULT 0") ' Add a default value for the "status" column (0 for False)
        imageTypeColumns.Add("with_date", "TIMESTAMP DEFAULT CURRENT_TIMESTAMP") ' Use TIMESTAMP for auto-generating dates
        dbHelper.CreateTable(tableName, imageTypeColumns)
    End Sub

End Class
