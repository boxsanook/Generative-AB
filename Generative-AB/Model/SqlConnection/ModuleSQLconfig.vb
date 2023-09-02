
Module ModuleSQLconfig
    Public SQLSettingName As String = "Generative-AB"
    Public SQLSetting As String = "SQLite"
    Public Set_txtHost As String = Nothing
    Public Set_txtPort As String = Nothing
    Public Set_txtUser As String = Nothing
    Public Set_txtPassword As String = Nothing
    Public Set_txtDatabase As String = Nothing
    Public Set_mysqldumpPath As String = Nothing
    Public Set_ImagePath As String = Nothing
    Public Sub GetSQLSetting()
        SQLSetting = "SQLite"
        Set_txtHost = RegistryB.GetValueFromRegistry("Host")
        Set_txtPort = RegistryB.GetValueFromRegistry("Port")
        Set_txtUser = RegistryB.GetValueFromRegistry("User")
        Set_txtPassword = RegistryB.GetValueFromRegistry("Password")
        Set_txtDatabase = RegistryB.GetValueFromRegistry("Database")
        Set_mysqldumpPath = RegistryB.GetValueFromRegistry("mysqldumpPath")
        Set_ImagePath = RegistryB.GetValueFromRegistry("ImagePath ")

        'txtConfigName.Text = RegistryB.GetValueFromRegistry("ConfigName")
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)
        'txtDatabase.Text = RegistryB.GetValueFromRegistry("Database", userRoot)
        'mysqldumpPath.Text = RegistryB.GetValueFromRegistry("SQLitePath", userRoot)
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)

    End Sub
End Module
