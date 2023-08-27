Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports ImageMagick

Public Class FRM_Convert_Image
    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click
        Me.Close()
    End Sub
    Private Sub FRM_Convert_Image_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Zoom_index()
    End Sub
    Public Sub Zoom_index()
        Com_Zoom.Items.Clear()
        For i As Integer = 1 To 30
            Com_Zoom.Items.Add(i)
        Next
        Com_Image_Type.SelectedIndex = 0
        Com_Zoom.SelectedIndex = 1
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRemoveColor.CheckedChanged
        If CheckBoxRemoveColor.Checked = True Then
            Dim colorDialog As New ColorDialog()
            ' Display the color dialog and check if the user clicked OK
            If colorDialog.ShowDialog() = DialogResult.OK Then
                ' Get the selected color
                Dim selectedColor As Color = colorDialog.Color
                ' Use the selected color as needed
                ' For example, set the BackColor of a control
                CheckBoxRemoveColor.ForeColor = selectedColor
            End If
        End If

    End Sub

    Private Sub SaveTo_Click(sender As Object, e As EventArgs) Handles SaveTo.Click
        ' Create a new instance of FolderBrowserDialog
        Dim folderBrowserDialog1 As New FolderBrowserDialog()
        ' Show the dialog and check if the user clicked OK
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFolder As String = folderBrowserDialog1.SelectedPath
            SelectedFolderPathTextBox.Text = selectedFolder
        End If
    End Sub
    Private Sub LoadImage_Click(sender As Object, e As EventArgs) Handles LoadImage.Click

        Dim irow As Integer = 0
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True ' Allow multiple file selection
        ImageListBox.Items.Clear()
        ' Filter the types of files to show in the dialog
        openFileDialog.Filter = "Image Files|*.svg;*.jpg;*.png;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file paths
            Dim selectedFiles As String() = openFileDialog.FileNames
            ' Process the selected files
            For Each filePath As String In selectedFiles
                Dim directoryPath As String = Path.GetDirectoryName(filePath)
                If irow = 0 Then
                    irow = irow + 1
                    LoadFIleFolder.Text = directoryPath
                End If
                ImageListBox.Items.Add(filePath)

            Next
        End If


    End Sub
    Public Magick_Format As MagickFormat = MagickFormat.Png
    Dim Com_Image_Type_new As String
    Dim zoom_size As Integer
    Dim SaveToFolder As String
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Com_Image_Type.Text = ".png" Then
            Magick_Format = MagickFormat.Png
        ElseIf Com_Image_Type.Text = ".jpg" Then
            Magick_Format = MagickFormat.Jpg
        ElseIf Com_Image_Type.Text = ".jpeg" Then
            Magick_Format = MagickFormat.Jpeg
        End If
        Me.label2.Text = ImageListBox.Items.Count

        Com_Image_Type_new = Com_Image_Type.Text
        zoom_size = Com_Zoom.Text
        SaveToFolder = SelectedFolderPathTextBox.Text
        ' New BackgroundWorker
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True

        ' Start the asynchronous operation.
        bgWorker.RunWorkerAsync()
        Me.btnStart.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If bgWorker.WorkerSupportsCancellation = True Then
            ' Cancel the asynchronous operation.
            bgWorker.CancelAsync()
        End If
        Me.btnStart.Enabled = True
    End Sub
    Private WithEvents bgWorker As BackgroundWorker
    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim Items_Count As Integer = ImageListBox.Items.Count
        Dim i As Integer = 0
        For Each item As Object In ImageListBox.Items
            i = i + 1
            ' Do something with each item
            Dim filePath As String = item.ToString()
            ' ... Perform any actions you need with the listItem
            worker.ReportProgress(i * 100 / Items_Count)
            ' Do something with the file path, e.g., display it in a ListBox

            Dim fileInfo As New FileInfo(filePath)
            Dim fileNameOnly As String = Path.GetFileName(filePath)
            Application.DoEvents()
            Try
                Dim get_site As Size
                get_site = ConverterImage.GetSvgDimensions_Size(filePath)
                Dim new_path As String = SaveToFolder & "\" & Replace(fileNameOnly, fileInfo.Extension, Com_Image_Type_new)
                FilesInFolder.CheckNewDirectory(SaveToFolder)


                If Skip_existing_files.Checked = True Then
                    If FilesInFolder.CheckFile(new_path) = True Then
                        ConverterImage.ConvertSvgTo_Png(filePath, new_path, get_site.Width * Convert.ToInt64(zoom_size), get_site.Height * Convert.ToInt64(zoom_size), Magick_Format)
                        If CheckBoxRemoveColor.Checked = True Then
                            Dim newBackgroundColor As Color = CheckBoxRemoveColor.ForeColor ' Replace with your desired background color
                            Dim htmlCode As String = ConverterImage.ColorToHtmlCode(newBackgroundColor)
                            Console.WriteLine($"htmlCode : {htmlCode} ")
                            Dim backgroundColor As New MagickColor(htmlCode) ' Replace #FFFFFF with your background color
                            ConverterImage.RemoveBackground_Png(new_path, new_path, backgroundColor)
                        End If
                    End If
                Else
                    ConverterImage.ConvertSvgTo_Png(filePath, new_path, get_site.Width * Convert.ToInt64(zoom_size), get_site.Height * Convert.ToInt64(zoom_size), Magick_Format)
                    If CheckBoxRemoveColor.Checked = True Then
                        Dim newBackgroundColor As Color = CheckBoxRemoveColor.ForeColor ' Replace with your desired background color
                        Dim htmlCode As String = ConverterImage.ColorToHtmlCode(newBackgroundColor)
                        Console.WriteLine($"htmlCode : {htmlCode} ")
                        Dim backgroundColor As New MagickColor(htmlCode) ' Replace #FFFFFF with your background color
                        ConverterImage.RemoveBackground_Png(new_path, new_path, backgroundColor)
                    End If
                End If

            Catch ex As Exception
                Thread.Sleep(2000)
                MessageBox.Show(ex.Message, "Work Error")
                'Dim get_site As Size
                'get_site = ConverterImage.GetSvgDimensions_Size(filePath)
                ''ConverterImage.ConvertSvgTo_Png(filePath, SaveTo & "\" & Replace(fileNameOnly, fileInfo.Extension, Com_Image_Type.Text), get_site.Width * Convert.ToInt64(zoom_size), get_site.Height * Convert.ToInt64(zoom_size), Magick_Format)

            End Try

            If (worker.CancellationPending = True) Then
                e.Cancel = True
                Exit For

            End If
        Next

    End Sub

    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        Me.label1.Text = (e.ProgressPercentage.ToString() + "%")

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            Me.label1.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            Me.label1.Text = "Error: " & e.Error.Message
        Else
            MessageBox.Show("Working Finished.")
            Me.btnStart.Enabled = True
        End If



    End Sub
End Class