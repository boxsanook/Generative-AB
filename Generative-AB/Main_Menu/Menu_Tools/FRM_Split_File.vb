Imports System.IO

Public Class FRM_Split_File

    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click
        Me.Close()
    End Sub
    Private Sub LoadImage_Click(sender As Object, e As EventArgs) Handles LoadImage.Click

        Dim irow As Integer = 0
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True ' Allow multiple file selection
        ImageListBox.Items.Clear()
        ' Filter the types of files to show in the dialog Image Files|*.png;*.jpg;*.jpeg; 
        openFileDialog.Filter = "All File |*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file paths
            Dim selectedFiles As String() = openFileDialog.FileNames
            ' Process the selected files
            For Each filePath As String In selectedFiles
                Dim directoryPath As String = Path.GetDirectoryName(filePath)
                If irow = 0 Then
                    irow = irow + 1
                    txt_SourcePath.Text = directoryPath
                End If
                Dim file_name As String = Path.GetFileName(filePath)
                ImageListBox.Items.Add(file_name)
            Next
            GroupBox3.Text = "Source Import File : " & ImageListBox.Items.Count & " Row"
        End If
    End Sub
    Public Sub MoveFile(sourceFilePath As String, destinationFilePath As String)
        Try
            ' Check if the source file exists
            If File.Exists(sourceFilePath) Then
                ' Move the file to the destination path
                File.Move(sourceFilePath, destinationFilePath)
                Console.WriteLine("File moved successfully.")
            Else
                Console.WriteLine("Source file does not exist.")
            End If
        Catch ex As Exception
            ' Handle any exceptions that might occur during the file move operation
            Console.WriteLine("Error while moving the file: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ImageListBox.Items.Count > 0 Then
            Dim Irow As Integer = 0
            Dim MoveFileTo As String = 0
            For Each rowx As String In ImageListBox.Items
                If Irow > TextBox1.Text Then
                    MoveFileTo = MoveFileTo + 1
                    Irow = 0
                    FilesInFolder.CheckNewDirectory(txt_SourcePath.Text & "\" & MoveFileTo)
                End If
                MoveFile(txt_SourcePath.Text & "\" & rowx, txt_SourcePath.Text & "\" & MoveFileTo & "\" & rowx)
                Irow = Irow + 1
            Next
            MessageBox.Show("  moved successfully.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()



        ' Show the dialog and check if the user clicked OK
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected folder path
            Dim selectedFolder As String = folderBrowserDialog.SelectedPath

            ' Specify the folder path
            Dim folderPath As String = selectedFolder

            ' Get all files in the root directory and its subdirectories
            Dim files As String() = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)

            ' Iterate through the files and print their names
            For Each file As String In files
                ImageListBox.Items.Add(file)
            Next

            ' Iterate through the files and print their names
            For Each file As String In files
                ImageListBox.Items.Add(file)
                Dim file_name As String = Path.GetFileName(file)
                MoveFile(file, selectedFolder & "\" & file_name)
            Next
        Else
            ' User clicked Cancel
            MessageBox.Show("No folder selected.")
        End If

    End Sub
End Class