Imports System.IO

Public Class FRM_Move_File_Error

    Private Sub FRM_Move_File_Error_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create a new instance of FolderBrowserDialog
        Dim folderBrowserDialog1 As New FolderBrowserDialog()

        ' Show the dialog and check if the user clicked OK
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected folder path from the dialog
            Dim selectedFolderPath As String = folderBrowserDialog1.SelectedPath
            ' Do something with the selected folder path
            ' For example, display it in a TextBox or process files in the folder
            MoveFileTo.Text = selectedFolderPath
        End If
    End Sub

    Private Sub Clear_Grid()
        DataGridView2.CancelEdit()
        DataGridView2.DataSource = Nothing
        DataGridView2.Columns.Clear()
    End Sub
    Dim RTN_Data As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear_Grid()
        Dim result As (DataTable, String) = ReadFile_CSV_Excel.OpenCsvFile()
        RTN_Data = New DataTable
        RTN_Data = result.Item1
        FilePath_Read.Text = result.Item2

        DataGridView2.DataSource = RTN_Data
        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Create a new instance of FolderBrowserDialog
        Dim folderBrowserDialog1 As New FolderBrowserDialog()

        ' Show the dialog and check if the user clicked OK
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected folder path from the dialog
            Dim selectedFolderPath As String = folderBrowserDialog1.SelectedPath
            ' Do something with the selected folder path
            ' For example, display it in a TextBox or process files in the folder
            OriginalPath.Text = selectedFolderPath
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

    Private Sub BT_Start_Click(sender As Object, e As EventArgs) Handles BT_Start.Click
        If RTN_Data.Rows.Count > 0 Then
            For Each rowx As DataRow In RTN_Data.Rows
                Dim cellValue As Object = rowx("Original filename")
                MoveFile(OriginalPath.Text & "\" & cellValue, MoveFileTo.Text & "\" & cellValue)
                Console.WriteLine(cellValue)
            Next
            MessageBox.Show("  moved successfully.")
        End If
    End Sub
End Class