

Public Class FRM_SettingSQLite
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub

    Private Sub FFRM_New_Setting_API_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_Run()
        If ModuleSQLconfig.Set_txtDatabase <> "Database" Then
            txtDatabase.Text = ModuleSQLconfig.Set_txtDatabase
            mysqldumpPath.Text = ModuleSQLconfig.Set_mysqldumpPath
            txtImagePath.Text = ModuleSQLconfig.Set_ImagePath
            txtConfigName.Text = ModuleSQLconfig.SQLSettingName
        End If

    End Sub
    Public Sub Main_Run()
        If FilesInFolder.DriveInfoPaht() Then
            mysqldumpPath.Text = "C:\Generative AB.ai\Database\"
            txtImagePath.Text = "C:\Generative AB.ai\Image\"
        Else
            mysqldumpPath.Text = "d:\Generative AB.ai\Database\"
            txtImagePath.Text = "d:\Generative AB.ai\Image\"
        End If
        ModuleSQLconfig.ConfugRegistryRoot = "Software\" & txtConfigName.Text
        'txtConfigName.Text = RegistryB.GetValueFromRegistry("ConfigName")
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)
        'txtDatabase.Text = RegistryB.GetValueFromRegistry("Database", userRoot)
        'mysqldumpPath.Text = RegistryB.GetValueFromRegistry("SQLitePath", userRoot)
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        Try

            If txtImagePath.Text = "" Then
                txtImagePath.Text = "C:\Generative AB.ai\Image\"
            End If
            RegistryB.SaveValueToRegistry("ConfigName", txtConfigName.Text)
            RegistryB.SaveValueToRegistry("DatabaseType", ModuleSQLconfig.SQLSetting, ModuleSQLconfig.ConfugRegistryRoot)
            RegistryB.SaveValueToRegistry("Host", Set_txtHost, ModuleSQLconfig.ConfugRegistryRoot)
            RegistryB.SaveValueToRegistry("Port", Set_txtPort, ModuleSQLconfig.ConfugRegistryRoot)
            RegistryB.SaveValueToRegistry("User", Set_txtUser, ModuleSQLconfig.ConfugRegistryRoot)
            RegistryB.SaveValueToRegistry("Password", Set_txtPassword, ModuleSQLconfig.ConfugRegistryRoot)
            RegistryB.SaveValueToRegistry("Database", txtDatabase.Text, ModuleSQLconfig.ConfugRegistryRoot)
            RegistryB.SaveValueToRegistry("mysqldumpPath", mysqldumpPath.Text, ModuleSQLconfig.ConfugRegistryRoot)
            RegistryB.SaveValueToRegistry("ImagePath", txtImagePath.Text, ModuleSQLconfig.ConfugRegistryRoot)


            FilesInFolder.CheckNewDirectory(mysqldumpPath.Text)
            FilesInFolder.CheckNewDirectory(txtImagePath.Text)

            Dim SQLiteTable As New SQLiteTable(mysqldumpPath.Text & txtDatabase.Text)
            SQLiteTable.NewTable()

            Application.Restart()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            mysqldumpPath.Text = FolderBrowserDialog1.SelectedPath & "\Database\"
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtImagePath.Text = FolderBrowserDialog1.SelectedPath & "\Image\"
        End If
    End Sub
End Class