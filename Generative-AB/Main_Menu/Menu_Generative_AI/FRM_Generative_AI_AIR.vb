Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FRM_Generative_AI_AIR
    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click
        Me.Close()
    End Sub

    Private Sub BT_Celar_All_Click(sender As Object, e As EventArgs) Handles BT_Celar_All.Click
        RegistryB.accessToken_app("regit")

        TextBox1.Text = RegistryB.str_accessToken
        TXT_Excel.Text = RegistryB.str_accessTokenExpiresAt
        'TextBox2.Text = xTime.UnixTimeStampToDateTime(response.accessTokenExpiresAt)
    End Sub
    Dim DataGiffExcell As New DataTable
    Public Sub ClearDataExcell()
        DataExcell.CancelEdit()
        DataExcell.Columns.Clear()
        DataExcell.DataSource = Nothing
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Excel Files (*.xls; *.xlsx)|*.xls;*.xlsx"
        openFileDialog1.Title = "Select an Excel File"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog1.FileName
            TXT_Excel.Text = selectedFilePath

            Dim New_load As New FRM_PopupFormExcel()
            New_load.selectedFilePath = selectedFilePath
            New_load.WindowState = FormWindowState.Normal
            'New_load.Location = New Point(Me.Location.Y, Me.Location.X)
            'New_load.Size = FRM_Main_Menu.GGet_Size()
            'New_load.Location = FRM_Main_Menu.GGet_Location()
            New_load.StartPosition = FormStartPosition.CenterScreen
            New_load.RunLoadExcel()
            New_load.ShowDialog()

            DataGiffExcell = New DataTable
            DataGiffExcell = New_load.Get_Data


            ClearDataExcell()
            DataExcell.DataSource = DataGiffExcell
            DataExcell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataExcell.AutoResizeColumns()
            'If DataGiffExcell.Columns.Contains("keyword") Or DataGiffExcell.Columns.Contains("sub_keyword") Or DataGiffExcell.Columns.Contains("prompt") Or DataGiffExcell.Columns.Contains("prompt_loop") Then
            '    ' Column exists in the DataTable
            '    ' Perform your desired actions here 
            '    'DataExcell.DataSource = DataGiffExcell
            '    'DataExcell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '    'DataExcell.AutoResizeColumns()
            'Else
            '    ' Column does not exist in the DataTable
            '    ' Handle the case where the column is not found
            '    MessageBox.Show("รูปแบบของไฟล์ไม่ถูกต้อง", "Error Format Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'DataGridPO_TXT.Dock = DockStyle.Fill
            'DataGridPO_TXT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ' Perform actions with the selected PDF file here  
            If DataGiffExcell.Rows.Count > 0 Then

            Else
                MessageBox.Show("No Data In Excel File", "No Data In Excel")
            End If

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim prompt As String = TextBox2.Text ' "gift,lady, balloon, shopping, sale, discount"
        Dim negativePrompt As String = Nothing ' "By Boxs me Tool"
        Dim complexities As String = Nothing ' 3 
        Dim mixedPresets As New List(Of KeyValuePair(Of String, Double))
        mixedPresets.Add(New KeyValuePair(Of String, Double)("digital_illustration_3d", 0.5))
        Dim colors As New List(Of Integer())
        colors.Add(New Integer() {255, 0, 0})
        colors.Add(New Integer() {0, 255, 0})
        colors.Add(New Integer() {0, 0, 255})
        Dim backgroundColor As New List(Of Integer())   ' New List(Of Integer()) From {New Integer() {255, 255, 255}}
        backgroundColor.Add(New Integer() {255, 255, 255})

        Dim random_seed As String = recraft_ai.New_random()
        Dim imageType As String = "vector_illustration"
        Dim layerHeight As Integer = 768
        Dim layerWidth As Integer = 768
        Dim randomSeed As Long = random_seed


        Dim jsonObject As JObject = API_AI.CreateJsonObject(prompt, negativePrompt, complexities, mixedPresets, colors, backgroundColor, imageType, layerHeight, layerWidth, randomSeed)
        ' Now you can use the jsonObject as needed, for example, you can convert it to a JSON string
        Dim jsonString As String = jsonObject.ToString()
        Console.WriteLine(jsonString)

        Dim STR_yourToken As String = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6IlJmUnEwV0FmTEhuV2RobkZXMWllXyJ9.eyJpc3MiOiJodHRwczovL3JlY3JhZnRhaS51cy5hdXRoMC5jb20vIiwic3ViIjoiZ29vZ2xlLW9hdXRoMnwxMTIxNDU4ODI2MDY1OTc5NjcxMzQiLCJhdWQiOlsicmVjcmFmdC1iYWNrZW5kIiwiaHR0cHM6Ly9yZWNyYWZ0YWkudXMuYXV0aDAuY29tL3VzZXJpbmZvIl0sImlhdCI6MTY5MzYxMzM2NiwiZXhwIjoxNjkzNjk5NzY2LCJhenAiOiI1aGd6MGUyb1FwbzJBOVhwOGE4MHJqVndCRUh3SEtsQiIsInNjb3BlIjoib3BlbmlkIHByb2ZpbGUgZW1haWwgcmVhZDphbGwgb2ZmbGluZV9hY2Nlc3MifQ.W6fm-pF1QUGSrZL4bUbMNCT9hvhD2K4czBJkfZ87Q46efznCNa-5dVIUtY2Tew_BQ_5sxeW5fL1RbLApsWXtOIPUT_K1Kj6z-7in0AdgeW3EjUv64o_Y6B1N3D3hTQaJfI8IjUa16joxFKq3lWJ_84Wx8dg3AXGPZpUqf7XP3ro05l63HRJdwh2Q-SKtcvzMSvmB5b2C9jkucsJlE2QLThkz15Jkx8hEZ1mWdjSubWK_oLjX-npspD0Y9x1V-eqnU0056zueWvupCWKAFPF6oVfYlnmncXw3tdxuoHHAFhqPCieIaqUY4Z4N9WPJ1X4c2981gyvzWB5LYE_FF48Zrg"
        Dim STR_yourProject As String = "463c777f-7e7b-47fb-b274-524a5699b468"
        Dim operationId As String = API_AI.Main_Recraft_new(STR_yourToken, STR_yourProject, jsonObject.ToString())
        Dim data_poll_recraft As String = String.Empty
        'Threading.Thread.Sleep(1000)
        data_poll_recraft = recraft_ai.api_poll_recraft(STR_yourToken, STR_yourProject, operationId)
        Dim data As JObject = JObject.Parse(data_poll_recraft)
        Dim images As JArray = DirectCast(data("images"), JArray)
        Dim count_for As Integer = 0
        For Each image As JObject In images
            count_for += 1
            Dim image_id As String = image.Value(Of String)("image_id")
            Dim file_url As String = $"{recraft_ai.baseUrl}/{STR_yourProject}/image/{image_id}"
            Dim output_folder As String = "image"
            If Not Directory.Exists(output_folder) Then
                Directory.CreateDirectory(output_folder)
            End If
            Threading.Thread.Sleep(3000)
            Dim filename_svg As String = $"{random_seed}_{count_for}.png"
            Dim output_path_svg As String = Path.Combine(output_folder, filename_svg)
            recraft_ai.download_file(STR_yourToken, STR_yourProject, file_url, output_path_svg, filename_svg)
            Threading.Thread.Sleep(3000)
            'API_AI.Recraft_remove_from_history(STR_yourToken, image_id)
        Next


    End Sub
End Class