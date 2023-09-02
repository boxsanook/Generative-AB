


Public Class FRM_SettingMySQL
    Private Sub FFRM_New_Setting_API_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        Try


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
            ImagePath.Text = FolderBrowserDialog1.SelectedPath & "\Image\"
        End If
    End Sub
End Class