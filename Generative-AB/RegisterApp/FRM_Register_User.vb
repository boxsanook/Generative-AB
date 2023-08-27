Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Public Class FRM_Register_User

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

    Private Sub FRM_Register_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_Key()
    End Sub


    Public Sub Main_Key()
        Dim SerialNumber As String = Get_Object_OS.CIM_SystemWin32("CIM_BIOSElement", "SerialNumber")
        If SerialNumber = "" Then
            SerialNumber = Get_Object_OS.CIM_SystemWin32("CIM_DiskDrive", "SerialNumber")
        End If
        If SerialNumber = "" Then
            SerialNumber = Get_Object_OS.CIM_SystemWin32("CIM_PhysicalMemory", "SerialNumber")
        End If
        RUsername.Text = API_register.RegexCode(SerialNumber)


        Dim dateTime As DateTime = DateTime.UtcNow.Date
        Dim NextMonth As DateTime
        ' Remove the trailing dash at the end of the string
        Dim ProductCode = RegistryB.ProductCode
        Dim txt_Cliente_ID = API_register.RegexCode(SerialNumber)
        Dim txt_sKey = API_register.RegexCode(API_register.random_code())
        Dim txt_uKey = API_register.RegexCode(API_register.random_code())
        NextMonth = dateTime.AddDays(Integer.Parse(15))
        Dim ExpiryDate = NextMonth.ToString("yyyy-MM-dd HH:mm:ss")
        Dim Register = $"{ProductCode }|{ txt_Cliente_ID }|{txt_sKey }|{ txt_uKey  }|{ ExpiryDate }|"
        Key.Text = BB_Framework_Code.BCryptography.Encrypt(Register)

    End Sub
    Private Sub RUsername_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles RUsername.Enter
        If RUsername.Text = "Username" Then
            RUsername.Text = ""
            RUsername.ForeColor = Color.LightGray
            Panel1.BackColor = Color.Orange
        End If
    End Sub
    Private Sub RUsername_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles RUsername.Leave
        If RUsername.Text = "" Then
            RUsername.Text = "Username"
            RUsername.ForeColor = Color.Silver
            Panel1.BackColor = Color.White
        Else
            Panel1.BackColor = Color.Green
        End If
    End Sub
    Private Sub REmail_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles REmail.Enter
        If REmail.Text = "Email" Then
            REmail.Text = ""
            REmail.ForeColor = Color.LightGray
            P1.BackColor = Color.Orange
        End If
    End Sub
    Private Sub REmail_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles REmail.Leave
        If REmail.Text = "" Then
            REmail.Text = "Email"
            REmail.ForeColor = Color.Silver
            P1.BackColor = Color.White
        Else
            P1.BackColor = Color.Green
        End If
    End Sub

    Private Sub RPASSWORD_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles RPASSWORD.Enter
        If RPASSWORD.Text.ToUpper = "PASSWORD".ToUpper Then
            RPASSWORD.Text = ""
            RPASSWORD.ForeColor = Color.LightGray
            P2.BackColor = Color.Orange
        End If
    End Sub
    Private Sub RPASSWORD_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles RPASSWORD.Leave
        If RPASSWORD.Text = "" Then
            RPASSWORD.Text = "PASSWORD"
            RPASSWORD.ForeColor = Color.Silver
            P2.BackColor = Color.White
        Else
            P2.BackColor = Color.Green
        End If
    End Sub

    Private Sub RCONFIRMPASSWORD_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles RCONFIRMPASSWORD.Enter
        If RCONFIRMPASSWORD.Text.ToUpper = "CONFIRM PASSWORD".ToUpper Then
            RCONFIRMPASSWORD.Text = ""
            RCONFIRMPASSWORD.ForeColor = Color.LightGray
            P3.BackColor = Color.Orange
        End If
    End Sub
    Private Sub RCONFIRMPASSWORD_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles RCONFIRMPASSWORD.Leave
        If RCONFIRMPASSWORD.Text = "" Then
            RCONFIRMPASSWORD.Text = "CONFIRM PASSWORD"
            RCONFIRMPASSWORD.ForeColor = Color.Silver
            P3.BackColor = Color.White
        ElseIf RCONFIRMPASSWORD.Text = RPASSWORD.Text Then
            P3.BackColor = Color.Green
        Else
            P3.BackColor = Color.Red
        End If
    End Sub
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Public RegisterX As New DataTable
    Public Sub RegisterXB()
        RegisterX = New DataTable
        RegisterX.Columns.Add(New DataColumn("email", GetType(String)))
        RegisterX.Columns.Add(New DataColumn("password", GetType(String)))
        RegisterX.Columns.Add(New DataColumn("hKey", GetType(String)))
        RegisterX.Columns.Add(New DataColumn("uKey", GetType(String)))
    End Sub
    Dim EncyPassword As String
    Private Sub btc_Register_Click(sender As Object, e As EventArgs) Handles btc_Register.Click

        RegisterXB()
        If REmail.Text.ToUpper = "".ToUpper Or REmail.Text.ToUpper = " ".ToUpper Or REmail.Text.ToUpper = "EMAIL ADDRESS".ToUpper Or IsValidEmailFormat(REmail.Text) = False Then
            MessageBox.Show("Must input EMAIL ADDRESS")
            REmail.SelectAll()
            REmail.Focus()
            Exit Sub
        End If
        If RPASSWORD.Text.ToUpper = "".ToUpper Or RPASSWORD.Text.ToUpper = " ".ToUpper Or RPASSWORD.Text.ToUpper = "PASSWORD".ToUpper Then
            MessageBox.Show("Must input PASSWORD")
            RPASSWORD.SelectAll()
            RPASSWORD.Focus()
            Exit Sub
        End If
        If RCONFIRMPASSWORD.Text.ToUpper = "".ToUpper Or RCONFIRMPASSWORD.Text.ToUpper = " ".ToUpper Or RCONFIRMPASSWORD.Text.ToUpper = "CONFIRM PASSWORD".ToUpper Then
            MessageBox.Show("Must input CONFIRM PASSWORD")
            RCONFIRMPASSWORD.SelectAll()
            RCONFIRMPASSWORD.Focus()
            Exit Sub
        End If

        If RPASSWORD.Text.ToUpper <> RCONFIRMPASSWORD.Text.ToUpper Then
            MessageBox.Show("Password does not match with confirmation password")
            RCONFIRMPASSWORD.SelectAll()
            RCONFIRMPASSWORD.Focus()
            Exit Sub
        End If



        '.CryptoRegister.GenerateKey(SystemSerialNumber().ToString, CpuId()).ToString
    End Sub
End Class