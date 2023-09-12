
Module ModuleSQLconfig

    Public SQLSettingName As String = "Generative-AB"
    Public ConfugRegistryRoot As String = "Software\" & SQLSettingName
    Public SQLSetting As SQLOperator = SQLOperator.SQLite
    Public Set_txtHost As String = "127.0.0.1"
    Public Set_txtPort As String = "3306"
    Public Set_txtUser As String = "root"
    Public Set_txtPassword As String = "MyBoxs"
    Public Set_txtDatabase As String = "Database"
    Public Set_mysqldumpPath As String = "mysqldumpPath"
    Public Set_ImagePath As String = "ImagePath"
    Public SQLiteDadaSource As String = String.Empty
    Public Enum SQLOperator

        [SQLite]
        [MySQL]
    End Enum
    Public Sub Reset()

        RegistryB.SaveValueToRegistry("ConfigName", SQLSettingName)

        RegistryB.SaveValueToRegistry("DatabaseType", ModuleSQLconfig.SQLSetting, ModuleSQLconfig.ConfugRegistryRoot)
        RegistryB.SaveValueToRegistry("Host", Set_txtHost, ModuleSQLconfig.ConfugRegistryRoot)
        RegistryB.SaveValueToRegistry("Port", Set_txtPort, ModuleSQLconfig.ConfugRegistryRoot)
        RegistryB.SaveValueToRegistry("User", Set_txtUser, ModuleSQLconfig.ConfugRegistryRoot)
        RegistryB.SaveValueToRegistry("Password", Set_txtPassword, ModuleSQLconfig.ConfugRegistryRoot)
        RegistryB.SaveValueToRegistry("Database", Set_txtDatabase, ModuleSQLconfig.ConfugRegistryRoot)
        RegistryB.SaveValueToRegistry("mysqldumpPath", Set_mysqldumpPath, ModuleSQLconfig.ConfugRegistryRoot)
        RegistryB.SaveValueToRegistry("ImagePath", Set_ImagePath, ModuleSQLconfig.ConfugRegistryRoot)


    End Sub
    Public Sub GetSQLSetting()

        SQLSetting = RegistryB.GetValueFromRegistry("DatabaseType", ConfugRegistryRoot)
        Set_txtHost = RegistryB.GetValueFromRegistry("Host", ConfugRegistryRoot)
        Set_txtPort = RegistryB.GetValueFromRegistry("Port", ConfugRegistryRoot)
        Set_txtUser = RegistryB.GetValueFromRegistry("User", ConfugRegistryRoot)
        Set_txtPassword = RegistryB.GetValueFromRegistry("Password", ConfugRegistryRoot)
        Set_txtDatabase = RegistryB.GetValueFromRegistry("Database", ConfugRegistryRoot)
        Set_mysqldumpPath = RegistryB.GetValueFromRegistry("mysqldumpPath", ConfugRegistryRoot)
        Set_ImagePath = RegistryB.GetValueFromRegistry("ImagePath", ConfugRegistryRoot)
        If SQLSetting = SQLOperator.SQLite Then
            SQLiteDadaSource = Set_mysqldumpPath & "\" & Set_txtDatabase
            'Dim SQLiteHelper As New SQLiteHelper(Set_mysqldumpPath & "\" & Set_txtDatabase)
            Dim SQLiteTable As New SQLiteTable(SQLiteDadaSource)
            SQLiteTable.NewTable()
        End If


        'txtConfigName.Text = RegistryB.GetValueFromRegistry("ConfigName")
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)
        'txtDatabase.Text = RegistryB.GetValueFromRegistry("Database", userRoot)
        'mysqldumpPath.Text = RegistryB.GetValueFromRegistry("SQLitePath", userRoot)
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)

    End Sub
End Module
