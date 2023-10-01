Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FRM_Generative_AI_AIR
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
    ' Define a custom class to represent ComboBox items with tags
    Public Class ComboBoxItem
        Public Property Text As String
        Public Property Tag As Object

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub FRM_Generative_AI_AIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMain()
    End Sub
    Public Sub LoadMain()
        ' New BackgroundWorker
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True
        RegistryB.accessToken_app("regit")
        lbl_AccessToken.Text = "Access Token :" & xTime.TimeStampToDateTime(RegistryB.str_accessTokenExpiresAt)
        txt_complexities.SelectedIndex = 0
        txt_sell_on.SelectedIndex = 0

        Dim list_ai_image_type As New DataTable
        If ModuleSQLconfig.SQLSetting = SQLOperator.SQLite Then
            Dim SQLiteX As New SQLiteHelper(ModuleSQLconfig.Set_mysqldumpPath & ModuleSQLconfig.Set_txtDatabase)
            list_ai_image_type = New DataTable
            list_ai_image_type = SQLiteX.SelectData("air_image_type", " status='0'")
            If list_ai_image_type.Rows.Count > 0 Then
                ListImage_type.Items.Clear()

                For Each dtRow As DataRow In list_ai_image_type.Rows
                    Dim ListSTR As String = $"{dtRow("category")}->{dtRow("style_name")}"
                    Dim tagValue As String = dtRow("image_type").ToString()
                    ' Add the item to the ComboBox and assign the tag
                    Dim item3 As New ComboBoxItem()
                    item3.Text = ListSTR
                    item3.Tag = tagValue
                    ListImage_type.Items.Add(item3)
                    'ListImage_type.Items(ListImage_type.Items.Count - 1).Tag = tagValue

                Next
            End If

        ElseIf ModuleSQLconfig.SQLSetting = SQLOperator.MySQL Then

        End If
    End Sub
    Private Sub BT_Celar_All_Click(sender As Object, e As EventArgs) Handles BT_Celar_All.Click

        RegistryB.accessToken_app("regit")
        txtToken.Text = RegistryB.str_accessToken

        lbl_AccessToken.Text = "Access Token :" & xTime.TimeStampToDateTime(RegistryB.str_accessTokenExpiresAt)
        ' Now, expirationTime contains the DateTimeOffset with 7 seconds added

        'TextBox2.Text = xTime.UnixTimeStampToDateTime(response.accessTokenExpiresAt)
    End Sub
    Dim DataGiffExcell As New DataTable
    Public Sub ClearDataExcell()
        DataExcell.CancelEdit()
        DataExcell.Columns.Clear()
        DataExcell.DataSource = Nothing
    End Sub

    Private Sub ExportTemplate_Click(sender As Object, e As EventArgs) Handles ExportTemplate.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog()
        folderBrowserDialog1.Description = "Select a Folder"
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim db As New DataTable
            Dim currentDate As DateTime = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("yyMMdd_HHmmss")
            Dim selectedFolderPath As String = folderBrowserDialog1.SelectedPath & "\" & "prompt_" & formattedDate & ".xlsx"
            If ModuleSQLconfig.SQLSetting = SQLOperator.SQLite Then
                Dim SQLiteX As New SQLiteHelper(ModuleSQLconfig.Set_mysqldumpPath & ModuleSQLconfig.Set_txtDatabase)
                db = New DataTable
                db = SQLiteX.SelectData("master_prompt_image", "id='1'", "keyword,sub_keyword,prompt,prompt_loop,group_id")
            ElseIf ModuleSQLconfig.SQLSetting = SQLOperator.MySQL Then

            End If
            Module_Excel.ExportDatatableToExcel(db, selectedFolderPath)

        End If
    End Sub
    Private Sub btn_LoadExcel_Click(sender As Object, e As EventArgs) Handles btn_LoadExcel.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Excel Files (*.xls; *.xlsx)|*.xls;*.xlsx"
        openFileDialog1.Title = "Select an Excel File"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog1.FileName
            TXT_Excel.Text = selectedFilePath

            Dim New_load As New FRM_PopupFormExcel()
            New_load.selectedFilePath = selectedFilePath
            New_load.WindowState = FormWindowState.Normal
            New_load.StartPosition = FormStartPosition.CenterScreen
            New_load.RunLoadExcel()
            New_load.ShowDialog()
            DataGiffExcell = New DataTable
            DataGiffExcell = New_load.Get_Data
            ClearDataExcell()
            'DataExcell.DataSource = DataGiffExcell
            'DataExcell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataExcell.AutoResizeColumns()
            If DataGiffExcell.Columns.Contains("keyword") Or DataGiffExcell.Columns.Contains("sub_keyword") Or DataGiffExcell.Columns.Contains("prompt") Or DataGiffExcell.Columns.Contains("prompt_loop") Then
                ' Column exists in the DataTable
                ' Perform your desired actions here 
                DataExcell.DataSource = DataGiffExcell
                DataExcell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                DataExcell.AutoResizeColumns()
            Else
                ' Column does not exist in the DataTable
                ' Handle the case where the column is not found
                MessageBox.Show("รูปแบบของไฟล์ไม่ถูกต้อง", "Error Format Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If
    End Sub

    Dim randomSeed As Long
    Dim selectedItemCount As Integer = 0
    Dim imageTypes_list As List(Of String)
    Private WithEvents bgWorker As BackgroundWorker
    Dim complexities As String = 1
    Dim str_sell_on As String = ""
    Dim backgroundColor As New List(Of Integer())
    Dim colors As New List(Of Integer())
    Dim imageIdx As String = TimeServer_API.getTimestamp
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        imageIdx = TimeServer_API.getTimestamp.ToString
        If Long.Parse(RegistryB.str_accessTokenExpiresAt) < TimeServer_API.getTimestamp Then
            RegistryB.accessToken_app("regit")
            If Long.Parse(RegistryB.str_accessTokenExpiresAt) < TimeServer_API.getTimestamp Then
                MessageBox.Show("access Token Expires At", "Error !!!")
                Exit Sub
            End If
        End If

        If DataGiffExcell.Rows.Count <= 0 Then
            MessageBox.Show("Pls Upload Data")
            Exit Sub
        End If

        If C_backgroundColor.Checked = True Then
            backgroundColor.Add(New Integer() {255, 255, 255})
        End If

        If Check_Color.Checked = True Then
            colors.Add(New Integer() {255, 255, 255})
            'colors.Add(New Integer() {255, 0, 0})  
            'colors.Add(New Integer() {0, 255, 0})
            'colors.Add(New Integer() {0, 0, 255})
        End If

        ' New BackgroundWorker
        bgWorker = New BackgroundWorker
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = True
        selectedItemCount = ListImage_type.SelectedIndices.Count
        imageTypes_list = New List(Of String)
        Dim uniqueList As New List(Of String)
        If selectedItemCount <= 0 Then
            MessageBox.Show("Pls SelectImage Style :")
            Exit Sub
        Else
            ' Iterate through the selected items in the ListBox
            For Each selectedItem As Object In ListImage_type.SelectedItems
                If TypeOf selectedItem Is ComboBoxItem Then
                    ' If the selected item is of type ComboBoxItem
                    Dim item As ComboBoxItem = DirectCast(selectedItem, ComboBoxItem)
                    ' Access the item's tag property and add it to the list
                    uniqueList.Add(item.Tag.ToString())
                End If
            Next
            imageTypes_list = uniqueList.Distinct().ToList()
        End If
        str_sell_on = txt_sell_on.Text
        For Each item As String In imageTypes_list
            Console.WriteLine(item)
        Next

        If txt_complexities.Text = -1 Then
            complexities = Nothing
        Else
            complexities = txt_complexities.Text
        End If
        ' Start the asynchronous operation.
        bgWorker.RunWorkerAsync()
        Me.btnStart.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If bgWorker.WorkerSupportsCancellation = True Then
            ' Cancel the asynchronous operation.
            bgWorker.CancelAsync()
        End If
        ProgressBar1.Value = 0
        label1.Text = ""
        Me.btnStart.Enabled = True
    End Sub
    ' Function to update the TextBox with data
    Private Sub UpdateTextBox(textList As List(Of String))
        If TextBox1.InvokeRequired Then
            ' If called from a different thread, use Invoke to update UI
            TextBox1.Invoke(New Action(Of List(Of String))(AddressOf UpdateTextBox), textList)
            If Prompt_text.InvokeRequired Then
                Prompt_text.Invoke(New Action(Of List(Of String))(AddressOf UpdateTextBox), textList)
            Else
                ' Update the Prompt_text (assuming it's a TextBox) with the provided text
                Prompt_text.Text = textList(1) ' Assuming textList contains at least one string
            End If
        Else
            ' Update the TextBox with the provided text
            TextBox1.Text = textList(0) ' Assuming textList contains at least one string
            If textList.Count > 1 Then
                ' Update the Prompt_text with the second string if available
                Prompt_text.Text = textList(1)
            Else
                ' Handle the case where there is no second string in the list
                Prompt_text.Text = "N/A"
            End If
        End If
    End Sub



    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim dbHelper As New SQLiteHelper(ModuleSQLconfig.SQLiteDadaSource)
        Dim tableName As String = "master_image_description"

        If DataGiffExcell.Rows.Count > 0 Then
            Dim row As Integer = 0
            Dim all_row As Integer = DataGiffExcell.Rows.Count
            For Each iRow As DataRow In DataGiffExcell.Rows
                row = row + 1
                Dim pc As Integer = (row * 100) / all_row
                If pc > 100 Then
                    pc = 100
                End If
                worker.ReportProgress(pc)

                If Long.Parse(RegistryB.str_accessTokenExpiresAt) < TimeServer_API.getTimestamp Then


                    Threading.Thread.Sleep(1000)
                    RegistryB.accessToken_app("regit")
                    Threading.Thread.Sleep(60000)
                    RegistryB.accessToken_app("regit")
                    If Long.Parse(RegistryB.str_accessTokenExpiresAt) < TimeServer_API.getTimestamp Then
                        'MessageBox.Show("Working Finished.")
                        Dim result As DialogResult = MessageBox.Show("Access Token Expires .", "Error !!  ", MessageBoxButtons.YesNo)

                        If result = DialogResult.Yes Then
                            ' User clicked Yes, perform the desired action   
                            e.Cancel = True
                            Exit Sub
                        ElseIf result = DialogResult.No Then
                            ' User clicked No, handle the cancelation or alternative action
                            ' ...
                        End If
                    End If
                End If

                If (worker.CancellationPending = True) Then
                    e.Cancel = True
                    Exit Sub
                End If


                '{iRow("keyword")}
                Dim prompt As String = $"{ Replace(iRow("prompt"), "'", " ")}" ' "gift,lady, balloon, shopping, sale, discount"
                Dim negativePrompt As String = "" ' "By Boxs me Tool"

                Dim mixedPresets As New List(Of KeyValuePair(Of String, Double))
                mixedPresets.Add(New KeyValuePair(Of String, Double)("digital_illustration_glow", 1))
                mixedPresets.Add(New KeyValuePair(Of String, Double)("digital_illustration_80s", 1))
                mixedPresets.Add(New KeyValuePair(Of String, Double)("realistic_image", 1))



                'Dim random_seed As String = recraft_ai.New_random()

                Dim layerHeight As Integer = 768
                Dim layerWidth As Integer = 768
                Dim STR_yourToken As String = RegistryB.str_accessToken
                Dim STR_yourProject As String = RegistryB.str_projectCode
                Dim file_image_type As String = ".png"
                For iloop As Integer = 1 To iRow("prompt_loop") 'Loop data 
                    If selectedItemCount > 0 Then
                        For Each item As String In imageTypes_list
                            ' Assuming textList is a List(Of String) containing the data you want to update the TextBox controls with
                            Dim textList As New List(Of String)
                            textList.Add(item) ' Add the value for TextBox1
                            textList.Add("Rows " & row & ":" & iRow("prompt").ToString()) ' Add the value for Prompt_text (Optional) 
                            ' Call the UpdateTextBox function and pass the data
                            UpdateTextBox(textList)
                            Console.WriteLine(item)
                            If Long.Parse(RegistryB.str_accessTokenExpiresAt) < TimeServer_API.getTimestamp Then
                                e.Cancel = True
                                Exit Sub
                            End If
                            If (worker.CancellationPending = True) Then
                                e.Cancel = True
                                Exit Sub
                            End If
                            '====================================================================================================================
                            Try
                                randomSeed = recraft_ai.New_random()
                                Dim jsonString As String = API_AI.CreateJsonObject(prompt.Replace("'", " "), negativePrompt, complexities, mixedPresets, colors, backgroundColor, item, layerHeight, layerWidth, randomSeed)
                                Dim operationId As String = API_AI.Main_Recraft_new(STR_yourToken, STR_yourProject, jsonString)
                                Threading.Thread.Sleep(300)
                                If operationId IsNot String.Empty Then
                                    Dim data_poll_recraft As String = String.Empty
                                    Threading.Thread.Sleep(300)
                                    data_poll_recraft = API_AI.api_poll_recraft(STR_yourToken, STR_yourProject, operationId)
                                    Dim data As JObject = JObject.Parse(data_poll_recraft)
                                    Dim images As JArray = DirectCast(data("images"), JArray)
                                    Dim count_for As Integer = 0
                                    For Each image As JObject In images

                                        count_for += 1
                                        Dim image_id As String = image.Value(Of String)("image_id")
                                        Dim file_url As String = $"{recraft_ai.baseUrl}/{STR_yourProject}/image/{image_id}"
                                        Threading.Thread.Sleep(800)
                                        Using stream As Stream = recraft_ai.download_file_checkImage(STR_yourToken, STR_yourProject, file_url)
                                            file_image_type = API_AI.CheckImage_Format(stream)
                                        End Using
                                        Dim output_folder As String = ModuleSQLconfig.Set_ImagePath & "\" & Replace(iRow("keyword"), " ", "_") & "\" & file_image_type & "\"
                                        output_folder = output_folder.Replace("\\", "\")

                                        If Not Directory.Exists(output_folder) Then
                                            Directory.CreateDirectory(output_folder)
                                        End If

                                        Dim filename_svg As String = $"{imageIdx}_{randomSeed.ToString}_{count_for}.{file_image_type}"
                                        Dim output_path_svg As String = Path.Combine(output_folder, filename_svg)
                                        Dim jpg_status As HttpStatusCode
                                        jpg_status = API_AI.download_file(STR_yourToken, STR_yourProject, file_url, output_path_svg)

                                        If jpg_status = 200 Then

                                            If str_sell_on = "miricanvas" Then
                                                'Create a table
                                                Dim imageTypeColumns As New Dictionary(Of String, Object)()
                                                imageTypeColumns.Add("uniqueId", image_id)
                                                imageTypeColumns.Add("random_seed", randomSeed)
                                                imageTypeColumns.Add("Filename", $"{randomSeed.ToString}_{count_for}")
                                                imageTypeColumns.Add("filePath", output_path_svg)
                                                imageTypeColumns.Add("Image_Name", Nothing)
                                                imageTypeColumns.Add("Description", Nothing)
                                                imageTypeColumns.Add("Category_1", "212")
                                                imageTypeColumns.Add("Category_2", "166")
                                                imageTypeColumns.Add("Category_3", "0")
                                                imageTypeColumns.Add("keywords", Nothing)
                                                imageTypeColumns.Add("in_keyword", iRow("keyword"))
                                                imageTypeColumns.Add("in_sub_keyword", iRow("sub_keyword"))
                                                imageTypeColumns.Add("in_prompt", iRow("prompt"))
                                                dbHelper.InsertData(tableName, imageTypeColumns)

                                            Else

                                                Threading.Thread.Sleep(1000)
                                                Dim img64 As String
                                                If file_image_type = "svg" Then
                                                    file_image_type = "png"
                                                    'UpdateTextBox("Sleep :" & file_image_type)
                                                    img64 = ConverterImage.ConvertSvgTobase64(output_path_svg)
                                                Else

                                                    img64 = ConverterImage.ConvertImageToBase64(output_path_svg)
                                                    'img64 = Image_Drawing.image_2_base64(output_path_svg)

                                                End If

                                                Dim dtJson As New DataTable
                                                dtJson.Columns.Add(New DataColumn("ImageData", GetType(String)))
                                                dtJson.Columns.Add(New DataColumn("type_file", GetType(String)))
                                                dtJson.Columns.Add(New DataColumn("cliente_id", GetType(String)))
                                                dtJson.Rows.Add(img64, file_image_type, RegistryB.str_Cliente_ID)
                                                '====================================================================================================================


                                                Dim JsonWord As String = API_register.SendImageToServer(dtJson, "https://boxs.me/Generative%20AB.ai/upload_image/upload_image.php")

                                                Dim response As New With {
                                                        .status = "",
                                                        .message = "",
                                                        .title = "",
                                                        .description = "",
                                                        .keywords = ""
                                                    }
                                                response = JsonConvert.DeserializeAnonymousType(JsonWord, response)

                                                If response.status.ToUpper() = "OK" Then
                                                    Dim sp_keywords As String = response.keywords
                                                    If sp_keywords.Split(","c).Count < 25 Then
                                                        sp_keywords = $"{sp_keywords} "
                                                    End If
                                                    ' Create a table
                                                    Dim imageTypeColumns As New Dictionary(Of String, Object)()
                                                    imageTypeColumns.Add("uniqueId", image_id)
                                                    imageTypeColumns.Add("random_seed", randomSeed)
                                                    imageTypeColumns.Add("Filename", $"{randomSeed.ToString}_{count_for}")
                                                    imageTypeColumns.Add("filePath", output_path_svg)
                                                    imageTypeColumns.Add("Image_Name", response.title)
                                                    imageTypeColumns.Add("Description", response.description)
                                                    imageTypeColumns.Add("Category_1", "212")
                                                    imageTypeColumns.Add("Category_2", "166")
                                                    imageTypeColumns.Add("Category_3", "0")
                                                    imageTypeColumns.Add("keywords", response.keywords)
                                                    imageTypeColumns.Add("in_keyword", iRow("keyword"))
                                                    imageTypeColumns.Add("in_sub_keyword", iRow("sub_keyword"))
                                                    imageTypeColumns.Add("in_prompt", iRow("prompt"))
                                                    dbHelper.InsertData(tableName, imageTypeColumns)
                                                Else
                                                    'Create a table
                                                    Dim imageTypeColumns As New Dictionary(Of String, Object)()
                                                    imageTypeColumns.Add("uniqueId", image_id)
                                                    imageTypeColumns.Add("random_seed", randomSeed)
                                                    imageTypeColumns.Add("Filename", $"{randomSeed.ToString}_{count_for}")
                                                    imageTypeColumns.Add("filePath", output_path_svg)
                                                    imageTypeColumns.Add("Image_Name", Nothing)
                                                    imageTypeColumns.Add("Description", Nothing)
                                                    imageTypeColumns.Add("Category_1", "212")
                                                    imageTypeColumns.Add("Category_2", "166")
                                                    imageTypeColumns.Add("Category_3", "0")
                                                    imageTypeColumns.Add("keywords", Nothing)
                                                    imageTypeColumns.Add("in_keyword", iRow("keyword"))
                                                    imageTypeColumns.Add("in_sub_keyword", iRow("sub_keyword"))
                                                    imageTypeColumns.Add("in_prompt", iRow("prompt"))
                                                    dbHelper.InsertData(tableName, imageTypeColumns)
                                                End If
                                            End If
                                        End If
                                        Threading.Thread.Sleep(1100)
                                    Next
                                End If
                                Threading.Thread.Sleep(1100)
                            Catch ex As Exception

                            End Try


                        Next
                    End If
                Next
            Next
        End If


    End Sub

    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        Me.label1.Text = (e.ProgressPercentage.ToString() + "%")
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            'Me.lblResult.Text = "Canceled!"
            MessageBox.Show("Canceled!")
        ElseIf e.Error IsNot Nothing Then
            'Me.lblResult.Text = "Error: " & e.Error.Message
            MessageBox.Show("Error: " & e.Error.Message)
        Else

            MessageBox.Show("Working Finished.")
        End If
        Me.btnStart.Enabled = True

    End Sub

End Class