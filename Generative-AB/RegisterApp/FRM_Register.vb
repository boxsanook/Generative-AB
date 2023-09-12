Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class FRM_Register
#Region "Drag Form - Arrastrar/ mover Formulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseClick(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseClick, MeText.MouseClick, Me.MouseClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        End If

    End Sub
    Private Sub PanelBarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown, MeText.MouseDown, Me.MouseDown
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        End If
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove, MeText.MouseMove, Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FRM_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainLoad()
    End Sub
    Dim dateTime As DateTime = DateTime.UtcNow
    Dim NextMonth As DateTime
    Dim regitry As String
    Public Sub MainLoad()
        If RegistryB.GetValueFromRegistry("Cliente_ID") IsNot Nothing Then
            RegistryB.Regit_run("regit")
            regitry = "regit"
            Update_Register.Visible = True
            btnRegister.Visible = False
        Else
            Update_Register.Visible = False
            btnRegister.Visible = True
            RegistryB.Regit_run("New")
            regitry = "New"
        End If



        ProductCode.Text = RegistryB.ProductCode
        txt_Cliente_ID.Text = RegistryB.str_Cliente_ID 'API_register.RegexCode(SerialNumber)
        txt_sKey.Text = RegistryB.str_sKey '= API_register.RegexCode(API_register.random_code())
        txt_uKey.Text = RegistryB.str_uKey '= API_register.RegexCode(API_register.random_code()) 
        ExpiryDate.Text = RegistryB.str_ExpiryDate '= xTime.tImeConvert(NextMonth.ToString("yyyy-MM-dd HH:mm:ss"))
        RegisterKey.Text = $"{ProductCode.Text}|{ txt_Cliente_ID.Text}|{txt_sKey.Text}|{ txt_uKey.Text }|{ ExpiryDate.Text}|"
        RegisterKey.Text = BB_Framework_Code.BCryptography.Encrypt(RegisterKey.Text)

        Dim inputString As String = RegistryB.str_token
        Dim extractedNumber As Integer

        ' Try to parse the number from the string
        If Integer.TryParse(Regex.Match(inputString, "\d+").Value, extractedNumber) Then
            token.Text = extractedNumber
            ' 'extractedNumber' now contains the extracted integer value
            Console.WriteLine("Extracted Number: " & extractedNumber)
        Else
            Console.WriteLine("No valid number found in the string.")
            token.Text = RegistryB.str_token
        End If
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            Dim Product_Key1 As String = $"{ProductCode.Text}|{ txt_Cliente_ID.Text}|{txt_sKey.Text}|"
            Dim Product_Key2 As String = $"{ txt_uKey.Text }|{ExpiryDate.Text}|{token.Text}|"
            Product_Key1 = BB_Framework_Code.BCryptography.Encrypt(Product_Key1)
            Product_Key2 = BB_Framework_Code.BCryptography.Encrypt(Product_Key2)

            Dim table As New DataTable
            table.Columns.Add(New DataColumn("Product_Key1", GetType(String)))
            table.Columns.Add(New DataColumn("Product_Key2", GetType(String)))
            table.Rows.Add(Product_Key1, Product_Key2)
            Dim jsonb = API_register.register_app("register_app", table)

            Dim response As New With {
            .status = "",
            .message = "",
            .Product_Key1 = "",
            .Product_Key2 = ""
            }

            response = JsonConvert.DeserializeAnonymousType(jsonb, response)
            Console.WriteLine("register_app: " & jsonb.ToString)
            If response.status.ToUpper() = "OK" Then
                RegistryB.SaveValueToRegistry("Product_Code", ProductCode.Text)
                RegistryB.SaveValueToRegistry("Cliente_ID", txt_Cliente_ID.Text)
                RegistryB.SaveValueToRegistry("sKey", txt_sKey.Text)
                RegistryB.SaveValueToRegistry("uKey", txt_uKey.Text)
                RegistryB.SaveValueToRegistry("Expiry_Date", BB_Framework_Code.BCryptography.Encrypt(ExpiryDate.Text))
                RegistryB.SaveValueToRegistry("token", BB_Framework_Code.BCryptography.Encrypt(token.Text))
                MessageBox.Show(response.message)


                Application.Restart()
            Else
                MessageBox.Show(response.message)
            End If

        Catch ex As Exception
            Console.WriteLine("ERROR register : " & ex.Message)
        End Try
    End Sub

    Private Sub Update_Register_Click(sender As Object, e As EventArgs) Handles Update_Register.Click
        If RegistryB.Check_register_app(regitry) = True Then
            Application.Restart()
        Else
            MessageBox.Show("ไม่สามารถลงทะเบียนได้โปรดติดต่อ ผู้ให้บริการ" & vbNewLine & "Unable to register, please contact service provider.", "Unable to register !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Product_Key1 As String = $"{RegistryB.ProductCode}|{ RegistryB.str_Cliente_ID }|{RegistryB.str_sKey }|"
        Dim Product_Key2 As String = $"{RegistryB.str_uKey}|{RegistryB.str_ExpiryDate}|{RegistryB.str_token}|"
        Product_Key1 = BB_Framework_Code.BCryptography.Encrypt(Product_Key1)
        Product_Key2 = BB_Framework_Code.BCryptography.Encrypt(Product_Key2)
        Dim table As New DataTable
        table.Columns.Add(New DataColumn("Product_Key1", GetType(String)))
        table.Columns.Add(New DataColumn("Product_Key2", GetType(String)))
        table.Rows.Add(Product_Key1, Product_Key2)
        RegisterKey.Text = API_register.DataTableToJSONWithStringBuilder(table)
    End Sub
End Class