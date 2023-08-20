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
    Private Sub PanelBarraTitulo_MouseClick(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseClick, MeText.MouseClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        End If

    End Sub
    Private Sub PanelBarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown, MeText.MouseDown
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        End If
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove, MeText.MouseMove
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
    Dim dateTime As DateTime = DateTime.UtcNow.Date
    Dim NextMonth As DateTime
    Public Sub MainLoad()
        Dim SerialNumber As String = Get_Object_OS.CIM_SystemWin32("CIM_BIOSElement", "SerialNumber")
        If SerialNumber = "" Then
            SerialNumber = Get_Object_OS.CIM_SystemWin32("CIM_DiskDrive", "SerialNumber")
        End If
        If SerialNumber = "" Then
            SerialNumber = Get_Object_OS.CIM_SystemWin32("CIM_PhysicalMemory", "SerialNumber")
        End If

        ' Remove the trailing dash at the end of the string
        ProductCode.Text = RegistryB.ProductCode
        txt_Cliente_ID.Text = API_register.RegexCode(SerialNumber)
        txt_sKey.Text = API_register.RegexCode(API_register.random_code())
        txt_uKey.Text = API_register.RegexCode(API_register.random_code())
        NextMonth = dateTime.AddDays(Integer.Parse(15))
        ExpiryDate.Text = NextMonth.ToString("yyyy-MM-dd HH:mm:ss")
        RegisterKey.Text = $"{ProductCode.Text}|{ txt_Cliente_ID.Text}|{txt_sKey.Text}|{ txt_uKey.Text }|{ ExpiryDate.Text}|"
        RegisterKey.Text = BB_Framework_Code.TripleDES.xEncrypt(RegisterKey.Text)
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            Dim table As New DataTable
            table.Columns.Add(New DataColumn("Product_Code", GetType(String)))
            table.Columns.Add(New DataColumn("Cliente_ID", GetType(String)))
            table.Columns.Add(New DataColumn("Product_Key", GetType(String)))
            table.Rows.Add(ProductCode.Text, txt_Cliente_ID.Text, RegisterKey.Text)
            Dim jsonb = API_register.register_app(table)

            Dim response As New With {
            .status = "",
            .message = ""
            }
            response = JsonConvert.DeserializeAnonymousType(jsonb, response)
            Console.WriteLine("register_app: " & jsonb.ToString)
            If response.status.ToUpper() = "OK" Then
                RegistryB.SaveValueToRegistry("Product_Code", ProductCode.Text)
                RegistryB.SaveValueToRegistry("Cliente_ID", txt_Cliente_ID.Text)
                RegistryB.SaveValueToRegistry("Product_Key", ProductCode.Text)
                RegistryB.SaveValueToRegistry("sKey", txt_sKey.Text)
                RegistryB.SaveValueToRegistry("uKey", txt_uKey.Text)
                RegistryB.SaveValueToRegistry("Expiry_Date", BB_Framework_Code.TripleDES.xEncrypt(ExpiryDate.Text))
                MessageBox.Show(response.message)
            Else
                MessageBox.Show(response.message)
            End If

        Catch ex As Exception
            Console.WriteLine("ERROR register : " & ex.Message)
        End Try
    End Sub
End Class