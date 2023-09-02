


Public Class FRM_SettingSQLite
    Private Sub FFRM_New_Setting_API_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_Run()
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub
    Dim userRoot As String
    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        Try
            userRoot = "Software\" & txtConfigName.Text

            RegistryB.SaveValueToRegistry("DatabaseType", ModuleSQLconfig.SQLSetting, userRoot)
            RegistryB.SaveValueToRegistry("ConfigName", txtConfigName.Text)
            RegistryB.SaveValueToRegistry("Database", txtDatabase.Text, userRoot)
            RegistryB.SaveValueToRegistry("SQLitePath", mysqldumpPath.Text, userRoot)
            RegistryB.SaveValueToRegistry("SaveImagePath", txtImagePath.Text, userRoot)
            RegistryB.SaveValueToRegistry("SQLSetting", ModuleSQLconfig.SQLSetting, userRoot)
            Application.Restart()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Main_Run()
        If FilesInFolder.DriveInfoPaht() Then
            mysqldumpPath.Text = "C:\Generative AB.ai\Database\"
            txtImagePath.Text = "C:\Generative AB.ai\Image\"
        Else
            mysqldumpPath.Text = "d:\Generative AB.ai\Database\"
            txtImagePath.Text = "d:\Generative AB.ai\Image\"
        End If
        userRoot = "Software\" & txtConfigName.Text
        'txtConfigName.Text = RegistryB.GetValueFromRegistry("ConfigName")
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)
        'txtDatabase.Text = RegistryB.GetValueFromRegistry("Database", userRoot)
        'mysqldumpPath.Text = RegistryB.GetValueFromRegistry("SQLitePath", userRoot)
        'txtImagePath.Text = RegistryB.GetValueFromRegistry("SaveImagePath", userRoot)

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