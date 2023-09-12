Imports System.ComponentModel
Imports System.IO
Imports Newtonsoft.Json

Public Class FRM_Get_Keyword

    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click
        Me.Close()
    End Sub

    Private Sub FRM_Get_Keyword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' New BackgroundWorker
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True
    End Sub
    Private Sub LoadImage_Click(sender As Object, e As EventArgs) Handles LoadImage.Click

        Dim irow As Integer = 0
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True ' Allow multiple file selection
        ImageListBox.Items.Clear()
        ' Filter the types of files to show in the dialog
        openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;"

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


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If TextBox1.Text = "" Then
            uniqueId = TimeServer_API.getTimestamp
            TextBox1.Text = uniqueId
        Else
            uniqueId = TextBox1.Text
        End If


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
    End Sub

    Private WithEvents bgWorker As BackgroundWorker

    Dim uniqueId As String = TimeServer_API.getTimestamp
    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim dbHelper As New SQLiteHelper(ModuleSQLconfig.SQLiteDadaSource)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim i As Integer
        worker.ReportProgress(i * 10)
        For Each item As Object In ImageListBox.Items
            If (worker.CancellationPending = True) Then
                e.Cancel = True
                Exit For
            End If
            Dim filePath As String = item.ToString()
            Dim fileInfo As New FileInfo(filePath)
            Dim fileNameOnly As String = Path.GetFileName(filePath)
            Application.DoEvents()
            Dim img64 As String
            img64 = ConverterImage.ConvertImageToBase64(filePath)
            Dim dtJson As New DataTable
            dtJson.Columns.Add(New DataColumn("ImageData", GetType(String)))
            dtJson.Columns.Add(New DataColumn("type_file", GetType(String)))
            dtJson.Columns.Add(New DataColumn("cliente_id", GetType(String)))
            dtJson.Rows.Add(img64, fileInfo.Extension, RegistryB.str_Cliente_ID)
            '====================================================================================================================
            Threading.Thread.Sleep(300)
            Dim JsonWord As String = API_register.SendImageToServer(dtJson, "https://boxs.me/Generative%20AB.ai/upload_image/upload_image.php")
            Threading.Thread.Sleep(1000)
            Dim response As New With {
                    .status = "",
                    .message = "",
                    .title = "",
                    .description = "",
                    .keywords = ""
                }
            response = JsonConvert.DeserializeAnonymousType(JsonWord, response)
            Dim tableName As String = "master_image_keyword"
            If response.status.ToUpper() = "OK" Then

                ' Create a table
                Dim imageTypeColumns As New Dictionary(Of String, Object)()
                imageTypeColumns.Add("uniqueId", uniqueId)
                imageTypeColumns.Add("Filename", fileNameOnly)
                imageTypeColumns.Add("title", response.title)
                imageTypeColumns.Add("description", response.description)
                imageTypeColumns.Add("keywords", response.keywords)
                Dim Check As String = $"uniqueId='{uniqueId}' And Filename ='{fileNameOnly}'"
                If dbHelper.GetRowCount(tableName, Check) <= 0 Then
                    dbHelper.InsertData(tableName, imageTypeColumns)
                End If

            Else
                Dim imageTypeColumns As New Dictionary(Of String, Object)()
                imageTypeColumns.Add("uniqueId", uniqueId)
                imageTypeColumns.Add("Filename", fileNameOnly)
                imageTypeColumns.Add("title", response.message)
                imageTypeColumns.Add("description", String.Empty)
                imageTypeColumns.Add("keywords", String.Empty)

                Dim Check As String = $"uniqueId='{uniqueId}' And Filename ='{fileNameOnly}'"
                If dbHelper.GetRowCount(tableName, Check) <= 0 Then
                    dbHelper.InsertData(tableName, imageTypeColumns)
                End If

            End If

        Next

    End Sub

    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        'Me.lblResult.Text = (e.ProgressPercentage.ToString() + "%")
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            MessageBox.Show("Canceled!")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Error: " & e.Error.Message)
        Else
            MessageBox.Show("Working Finished.")

        End If
        Me.btnStart.Enabled = True
        Dim dbHelper As New SQLiteHelper(ModuleSQLconfig.SQLiteDadaSource)
        Dim DT As New DataTable
        Dim tableName As String = "master_image_keyword"
        DT = dbHelper.SelectData(tableName, "uniqueId ='" & TextBox1.Text & "'", "Filename as 'Filename',title as 'Image Name',description as 'Description',212 as 'Category 1','0' as 'Category 2','0' as 'Category 3',keywords as 'keywords', '0' as 'Free','1' as 'W-EL','0' as 'P-EL','0' as 'SR-EL','0' as 'SR-Price','1' as 'Editorial','' as 'MR doc Ids','' as 'Pr Docs' ")
        DataExcell.DataSource = DT
    End Sub

    Private Sub ExportToExcel_Click(sender As Object, e As EventArgs) Handles ExportToExcel.Click
        If DataExcell.Rows.Count > 0 And DataExcell.Rows.Count > 0 Then
            Dim folderBrowserDialog1 As New FolderBrowserDialog()
            folderBrowserDialog1.Description = "Select a Folder"
            If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Dim currentDate As DateTime = DateTime.Now
                Dim formattedDate As String = currentDate.ToString("yyyy_MM_dd_HH_mm_ss")
                Dim selectedFolderPath As String = folderBrowserDialog1.SelectedPath
                Dim export_to As String = selectedFolderPath & "\" & formattedDate & "_dreamstime.csv"
                Module_Excel.ExportToCSV(DataExcell, export_to)
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbHelper As New SQLiteHelper(ModuleSQLconfig.SQLiteDadaSource)
        Dim DT As New DataTable
        Dim tableName As String = "master_image_keyword"
        DT = dbHelper.SelectData(tableName, "uniqueId ='" & TextBox1.Text & "'", "Filename as 'Filename',title as 'Image Name',description as 'Description',212 as 'Category 1','0' as 'Category 2','0' as 'Category 3',keywords as 'keywords', '0' as 'Free','1' as 'W-EL','0' as 'P-EL','0' as 'SR-EL','0' as 'SR-Price','1' as 'Editorial','' as 'MR doc Ids','' as 'Pr Docs' ")
        'DT = dbHelper.SelectData(tableName, "uniqueId ='1694104603'", "Filename as 'Filename',title as 'Image Name',description as 'Description',212 as 'Category 1','' as 'Category 2','' as 'Category 3',keywords as 'keywords', '0' as 'Free','1' as 'W-EL','a' as 'P-EL','0' as 'SR-EL','0' as 'SR-Price','1' as 'Editorial','252233,252234' as 'MR doc Ids','1358' as 'Pr Docs' ")
        DataExcell.DataSource = DT

    End Sub
End Class