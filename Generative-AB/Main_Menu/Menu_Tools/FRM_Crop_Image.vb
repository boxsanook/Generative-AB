Imports System.ComponentModel
Imports System.IO
Imports System.Threading

Public Class FRM_Crop_Image
    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click

        If bgWorker.IsBusy Then
            Dim Confim As DialogResult = MessageBox.Show("System operation has not yet been completed." & vbNewLine & "Do you want to cancel and close this page?", "Do you want to close this page?", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If Confim = DialogResult.Yes Then
                Try
                    bgWorker.CancelAsync()
                Catch ex As Exception

                End Try
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub
    Private Sub InitializeDpiComboBox()
        ComboBoxDpi.Items.clear()
        For Each dpi As Single In {96, 150, 200, 300} ' Add more DPI options as needed
            ComboBoxDpi.Items.Add(dpi)
        Next
        ComboBoxDpi.SelectedIndex = 0 ' Set the default selected DPI
    End Sub

    Private Sub FRM_Convert_Image_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' New BackgroundWorker
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True

        Zoom_index()
        InitializeDpiComboBox()
    End Sub
    Public Sub Zoom_index()
        Com_Zoom.Items.Clear()
        For i As Integer = 1 To 30
            Com_Zoom.Items.Add(i)
        Next
        Com_Zoom.SelectedIndex = 1
    End Sub


    Private Sub SaveTo_Click(sender As Object, e As EventArgs) Handles SaveTo.Click
        ' Create a new instance of FolderBrowserDialog
        Dim folderBrowserDialog1 As New FolderBrowserDialog()
        ' Show the dialog and check if the user clicked OK
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFolder As String = folderBrowserDialog1.SelectedPath
            txt_OutputPath.Text = selectedFolder
        End If
    End Sub
    Private Sub LoadImage_Click(sender As Object, e As EventArgs) Handles LoadImage.Click

        Dim irow As Integer = 0
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True ' Allow multiple file selection
        ImageListBox.Items.Clear()
        ' Filter the types of files to show in the dialog
        openFileDialog.Filter = "Image Files|*.png;"

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
                ImageListBox.Items.Add(filePath)

            Next
        End If


    End Sub
    Public Image_Format As Imaging.ImageFormat = Imaging.ImageFormat.Png
    Dim SaveToFolder As String
    Dim margin As Integer = 20
    Dim minAlpha As Integer = 13 ' 5% of 255
    Dim maxAlpha As Integer = 51 ' 20% of 255
    Dim enlargementFactor As Double = 8 'Resize Image
    Dim dpi As Integer = 300 ' Desired DPI

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.wk_text.Text = String.Empty
        If txt_SourcePath.Text = "" Then
            MessageBox.Show("Please select the source of the image file.", "Empty Source Path", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txt_OutputPath.Text = "" Then
            MessageBox.Show("Please select the output path of the image file.", "Empty Output Path", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ImageListBox.Items.Count <= 0 Then
            MessageBox.Show("You have not selected the image you want to  convert.", "Empty Output Path", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.label2.Text = ImageListBox.Items.Count
        enlargementFactor = Integer.Parse(Com_Zoom.Text)
        SaveToFolder = txt_OutputPath.Text
        dpi = Integer.Parse(ComboBoxDpi.Text)
        ' New BackgroundWorker
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True
        Items_Count = ImageListBox.Items.Count
        ' Start the asynchronous operation.
        bgWorker.RunWorkerAsync()

        Me.btnStart.Enabled = False
        Me.GroupBox2.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If bgWorker.WorkerSupportsCancellation = True Then
            ' Cancel the asynchronous operation.
            bgWorker.CancelAsync()
        End If

        Me.btnStart.Enabled = True
        Me.GroupBox2.Enabled = True

    End Sub
    Private WithEvents bgWorker As BackgroundWorker
    Dim Items_Count As Integer = 0
    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        Dim i As Integer = 0
        For Each item As Object In ImageListBox.Items
            i = i + 1
            ' Do something with each item
            Dim filePath As String = item.ToString()
            worker.ReportProgress(i)

            ' ... Perform any actions you need with the listItem
            'Dim worker_PerCen As Integer = 0
            'worker_PerCen = i * 100 / Items_Count
            'If worker_PerCen <= 100 Then
            '    worker.ReportProgress(worker_PerCen)
            'Else
            '    worker.ReportProgress(100)
            'End If

            ' Do something with the file path, e.g., display it in a ListBox

            Dim fileInfo As New FileInfo(filePath)
            Dim fileNameOnly As String = Path.GetFileName(filePath)
            Application.DoEvents()
            Try
                Dim get_site As Size
                get_site = ConverterImage.GetSvgDimensions_Size(filePath)
                If fileInfo.Extension.ToUpper = ".png".ToUpper Then
                    Image_Format = Imaging.ImageFormat.Png
                ElseIf fileInfo.Extension.ToUpper = ".png".ToUpper Then
                    Image_Format = Imaging.ImageFormat.Jpeg
                End If

                Dim new_path As String = SaveToFolder & "\" & fileNameOnly
                FilesInFolder.CheckNewDirectory(SaveToFolder)
                If Skip_existing_files.Checked = True Then
                    If FilesInFolder.CheckFile(new_path) = True Then
                        Image_Drawing.CroppingSizeDPI(filePath, new_path, Image_Format, minAlpha, maxAlpha, margin, enlargementFactor, dpi)
                    End If
                Else
                    Image_Drawing.CroppingSizeDPI(filePath, new_path, Image_Format, minAlpha, maxAlpha, margin, enlargementFactor, dpi)

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
                Exit Sub

            End If
        Next

    End Sub

    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        Dim worker_PerCen As Integer = 0
        worker_PerCen = e.ProgressPercentage.ToString() * 100 / Items_Count
        If worker_PerCen <= 100 Then
            worker_PerCen = worker_PerCen
        Else
            worker_PerCen = worker_PerCen
        End If
        Dim diff As Integer = Integer.Parse(Items_Count) - Integer.Parse(e.ProgressPercentage)
        label2.Text = (diff.ToString + " / " + Items_Count.ToString)
        Me.label1.Text = (worker_PerCen.ToString + "%")
        ProgressBar1.Value = worker_PerCen
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            'Me.label1.Text = "Canceled!"
            MessageBox.Show("Working Canceled!")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message, "Working Error.")
            'Me.label1.Text = "Error: " &
        Else
            MessageBox.Show("Working Finished.")
        End If

        Me.btnStart.Enabled = True
        Me.GroupBox2.Enabled = True
    End Sub
End Class