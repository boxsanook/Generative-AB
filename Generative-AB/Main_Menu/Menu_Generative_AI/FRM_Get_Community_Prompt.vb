Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FRM_Get_Community_Prompt

    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click
        Me.Close()
    End Sub
    ' Define a custom class to represent ComboBox items with tags
    Public Class ComboBoxItem
        Public Property Text As String
        Public Property Tag As Object

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub FRM_Get_Community_Prompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMain()
    End Sub

    Public Sub LoadMain()
        ' New BackgroundWorker
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True

        ComOffset.Items.Clear()
        For i As Integer = 0 To 50
            ComOffset.Items.Add(i)
        Next
        ComOffset.SelectedIndex = 1
        RegistryB.accessToken_app("regit")
        lbl_AccessToken.Text = "Access Token :" & xTime.TimeStampToDateTime(RegistryB.str_accessTokenExpiresAt)
        txtToken.Text = RegistryB.str_accessToken
        Dim dateTime As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(RegistryB.str_accessTokenExpiresAt)
        lbl_AccessToken.Text = "Access Token :" & dateTime.ToString

        Dim list_ai_image_type As New DataTable
        If ModuleSQLconfig.SQLSetting = SQLOperator.SQLite Then
            Dim SQLiteX As New SQLiteHelper(ModuleSQLconfig.SQLiteDadaSource)
            list_ai_image_type = New DataTable
            list_ai_image_type = SQLiteX.SelectData("air_image_type", " status='0'")
            If list_ai_image_type.Rows.Count > 0 Then
                ListImage_type.Items.Clear()
                For Each dtRow As DataRow In list_ai_image_type.Rows
                    Dim ListSTR As String = $"{dtRow("category")}->{dtRow("style_name")}"
                    Dim tagValue As String = dtRow("image_type").ToString()
                    Dim item3 As New ComboBoxItem()
                    item3.Text = ListSTR
                    item3.Tag = tagValue
                    ListImage_type.Items.Add(item3)
                Next
            End If

        ElseIf ModuleSQLconfig.SQLSetting = SQLOperator.MySQL Then

        End If
    End Sub
    Private WithEvents bgWorker As BackgroundWorker
    Private imageTypes As New List(Of String)()
    Dim filter As String = String.Empty
    Dim Ito As Integer = 1
    Public Sub ClearDataExcell()
        DataExcell.CancelEdit()
        DataExcell.Columns.Clear()
        DataExcell.DataSource = Nothing
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Long.Parse(RegistryB.str_accessTokenExpiresAt) < TimeServer_API.getTimestamp Then
            RegistryB.accessToken_app("regit")
            If Long.Parse(RegistryB.str_accessTokenExpiresAt) < TimeServer_API.getTimestamp Then
                MessageBox.Show("access Token Expires At", "Error !!!")
                Exit Sub
            End If
        End If

        ClearDataExcell()
        If btnSearch.Tag = "Start" Then
            ' New BackgroundWorker
            bgWorker = New BackgroundWorker
            bgWorker.WorkerReportsProgress = True
            bgWorker.WorkerSupportsCancellation = True
            imageTypes = New List(Of String)()
            Ito = ComOffset.Text
            filter = TXT_filter.Text


            If ListImage_type.SelectedItems.Count > 0 Then
                For Each selectedItem As Object In ListImage_type.SelectedItems
                    If TypeOf selectedItem Is ComboBoxItem Then
                        ' If the selected item is of type ComboBoxItem
                        Dim item As ComboBoxItem = DirectCast(selectedItem, ComboBoxItem)
                        ' Access the item's tag property and add it to the list
                        imageTypes.Add(item.Tag.ToString())
                    End If
                Next
            End If

            ' Start the asynchronous operation.
            bgWorker.RunWorkerAsync()

            btnSearch.Tag = "Stop"
            btnSearch.Text = "Stop Search..."
        ElseIf btnSearch.Tag = "Stop" Then
            btnSearch.Tag = "Start"
            btnSearch.Text = "Search..."
            If bgWorker.WorkerSupportsCancellation = True Then
                ' Cancel the asynchronous operation.
                bgWorker.CancelAsync()
            End If
        End If


    End Sub

    Dim dt As New DataTable()
    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        dt = New DataTable()

        dt.Columns.Add("image_id", GetType(String))
        dt.Columns.Add("image_type", GetType(String))
        dt.Columns.Add("prompt", GetType(String))
        dt.Columns.Add("recraft_id", GetType(String))
        dt.Columns.Add("width", GetType(Integer))
        dt.Columns.Add("height", GetType(Integer))
        dt.Columns.Add("likes_count", GetType(Integer))
        dt.Columns.Add("dislikes_count", GetType(Integer))
        Dim i As Integer
        Dim loop_to As Integer = Ito
        Try
            For i = 0 To loop_to - 1
                If (worker.CancellationPending = True) Then
                    e.Cancel = True
                    Exit For
                Else
                    Dim type As String = "community"
                    Dim limit As Integer = 50
                    Dim offset As Integer = i * 50
                    Dim jsonData As String = API_AI.find_recraft_images(type, filter, imageTypes, limit, offset).ToString
                    jsonData = API_AI.Main_Post_AI(txtToken.Text, "https://api.recraft.ai/find_recraft_images", jsonData)
                    ' Deserialize the JSON data into a JObject
                    Dim jsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(jsonData)
                    ' Access the 'recraft_images' array
                    Dim recraftImages As JArray = jsonObject("recraft_images")
                    If recraftImages.Count > 0 Then
                        ' Create a DataTable with the desired columns
                        For Each image As JObject In recraftImages
                            Dim dislikesCount As Integer = image("dislikes_count").ToObject(Of Integer)()
                            Dim height As Integer = image("height").ToObject(Of Integer)()
                            Dim imageId As String = image("image_id").ToString()
                            Dim imageType As String = image("image_type").ToString()
                            Dim likesCount As Integer = image("likes_count").ToObject(Of Integer)()
                            Dim prompt As String = image("prompt").ToString()
                            Dim recraftId As String = image("recraft_id").ToString()
                            Dim width As Integer = image("width").ToObject(Of Integer)()

                            Dim outputString As String = prompt.Replace(vbCrLf, " ")
                            outputString = Regex.Replace(outputString, "\s+", "")

                            dt.Rows.Add(imageId, imageType, outputString, recraftId, width, height, likesCount, dislikesCount)

                            ' Now you can work with the individual image properties
                            ' For example, you can store them in variables or process them as needed
                        Next
                        'loop_to = loop_to + 1
                    End If

                    ' Perform a time consuming operation and report progress.
                    'System.Threading.Thread.Sleep(500)
                    'worker.ReportProgress(i * 100 / Ito)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR !!")
        End Try

    End Sub

    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        'If e.ProgressPercentage.ToString() >= 100 Then
        '    ProgressBar1.Value = (100 + "%")
        'Else
        '    ProgressBar1.Value = (e.ProgressPercentage.ToString() + "%")
        'End If

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            'Me.lblResult.Text = "Canceled!"
            MessageBox.Show("Canceled!")
        ElseIf e.Error IsNot Nothing Then
            'Me.lblResult.Text = "Error: " & e.Error.Message
            MessageBox.Show("Error: " & e.Error.Message)
        Else
            'Me.lblResult.Text = "Done!"
            MessageBox.Show("Working Finished.")
        End If
        DataExcell.DataSource = dt
        btnSearch.Tag = "Start"
        btnSearch.Text = "Search..."

    End Sub

    Private Sub ListImage_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListImage_type.SelectedIndexChanged
        'If ListImage_type.SelectedIndex <> -1 Then
        '    ' Get the selected item
        '    Dim selectedItem As ComboBoxItem = DirectCast(ListImage_type.SelectedItem, ComboBoxItem)
        '    ' Access the item's text and tag
        '    Dim itemText As String = selectedItem.Text
        '    Dim itemTag As Object = selectedItem.Tag
        '    MessageBox.Show(itemTag)
        '    ' Now you can work with itemText and itemTag as needed
        'End If

    End Sub

    Private Sub BT_Celar_All_Click(sender As Object, e As EventArgs) Handles BT_Celar_All.Click

        RegistryB.accessToken_app("regit")
        lbl_AccessToken.Text = "Access Token :" & xTime.TimeStampToDateTime(RegistryB.str_accessTokenExpiresAt)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataExcell.Rows.Count > 0 And DataExcell.Rows.Count > 0 Then
            Dim folderBrowserDialog1 As New FolderBrowserDialog()
            folderBrowserDialog1.Description = "Select a Folder"
            If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Dim currentDate As DateTime = DateTime.Now
                Dim formattedDate As String = currentDate.ToString("yyyy_MM_dd_HH_mm_ss")
                Dim selectedFolderPath As String = folderBrowserDialog1.SelectedPath
                Dim export_to As String = selectedFolderPath & "\no_data_" & formattedDate & "_PickingAndLabel.xlsx"
                Module_Excel.ExportToExcel(DataExcell, export_to)
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim STR_yourToken As String = RegistryB.str_accessToken
        Dim STR_yourProject As String = RegistryB.str_projectCode
        Dim file_image_type As String = ".png"
        For Each row As DataGridViewRow In DataExcell.Rows
            ' Check if the row is not the header row
            If Not row.IsNewRow Then
                ' Access the cell values for each column in the current row
                Dim image_id As String = row.Cells("image_id").Value.ToString()

                Dim file_url As String = $"{recraft_ai.baseUrl}/{STR_yourProject}/image/{image_id}"
                Threading.Thread.Sleep(800)
                Using stream As Stream = recraft_ai.download_file_checkImage(STR_yourToken, STR_yourProject, file_url)
                    file_image_type = API_AI.CheckImage_Format(stream)
                End Using
                Dim output_folder As String = ModuleSQLconfig.Set_ImagePath & "\" & Replace(TXT_filter.Text, " ", "_") & "\" & file_image_type & "\"
                output_folder = output_folder.Replace("\\", "\")

                If Not Directory.Exists(output_folder) Then
                    Directory.CreateDirectory(output_folder)
                End If

                Dim filename_svg As String = $"{Replace(image_id, "-", "")}.{file_image_type}"
                Dim output_path_svg As String = Path.Combine(output_folder, filename_svg)
                Dim jpg_status As HttpStatusCode
                jpg_status = API_AI.download_file(STR_yourToken, STR_yourProject, file_url, output_path_svg)


                ' Process or display the values as needed
                'Console.WriteLine($"Cell 1: {cell1Value}, Cell 2: {cell2Value}")
            End If
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Excel Files (*.xls; *.xlsx)|*.xls;*.xlsx"
        openFileDialog1.Title = "Select an Excel File"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog1.FileName

            Dim New_load As New FRM_PopupFormExcel()
            New_load.selectedFilePath = selectedFilePath
            New_load.WindowState = FormWindowState.Normal
            New_load.StartPosition = FormStartPosition.CenterScreen
            New_load.RunLoadExcel()
            New_load.ShowDialog()
            Dim DataGiffExcell As New DataTable
            DataGiffExcell = New_load.Get_Data
            ClearDataExcell()
            'DataExcell.DataSource = DataGiffExcell
            'DataExcell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataExcell.AutoResizeColumns()
            DataExcell.DataSource = DataGiffExcell
            DataExcell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataExcell.AutoResizeColumns()


        End If
    End Sub
End Class