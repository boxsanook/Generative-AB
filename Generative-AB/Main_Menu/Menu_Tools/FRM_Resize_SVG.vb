Imports System.IO

Public Class FRM_Resize_SVG

    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click
        Me.Close()
    End Sub
    Private Sub FRM_Resize_SVG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If ImageListBox.Items.Count > 0 Then
            For Each xItem As String In ImageListBox.Items
                Image_Drawing.ResizeSVG(xItem, Com_Zoom.Text, MinSize.Text, set_max.Checked)
            Next
            MessageBox.Show("Working Finished.")
        End If
    End Sub

    Private Sub LoadImage_Click(sender As Object, e As EventArgs) Handles LoadImage.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True ' Allow multiple file selection
        ImageListBox.Items.Clear()
        ' Filter the types of files to show in the dialog
        openFileDialog.Filter = "SVG Files|*.svg;"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim irow As Integer = 0
            ' Get the selected file paths
            Dim selectedFiles As String() = openFileDialog.FileNames
            ' Process the selected files
            For Each filePath As String In selectedFiles
                Dim directoryPath As String = Path.GetDirectoryName(filePath)
                If irow = 0 Then
                    irow = irow + 1
                    txt_SourcePath.Text = directoryPath
                End If
                ImageListBox.Items.Add(filePath)

            Next
        End If
    End Sub

    Private Sub Skip_existing_files_CheckedChanged(sender As Object, e As EventArgs) Handles Skip_existing_files.CheckedChanged

    End Sub
End Class