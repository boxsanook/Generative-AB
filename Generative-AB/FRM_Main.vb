Public Class FRM_Main

#Region "Main Funtion Form"
    Private Sub ResetButtonAppearance(panel As Panel)
        For Each button As Button In panel.Controls.OfType(Of Button)()
            ResetButton(button)
        Next
        For Each childPanel As Panel In panel.Controls.OfType(Of Panel)()
            ResetButtonAppearance(childPanel)
        Next
    End Sub

    Private Sub ResetButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub active_button(btnCustom As Button)
        btnCustom.FlatStyle = FlatStyle.Flat
        btnCustom.FlatAppearance.BorderSize = 1
        btnCustom.FlatAppearance.BorderColor = Color.Gold
    End Sub
    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False

        PanelToolsSubmenu.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub
#End Region



#Region "Buttons Media Submenu"

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click

        'Dim buttonName As String = clickedButton.Name
        showSubmenu(PanelMediaSubmenu)
        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        openChildForm(New FRM_Generative_AI_AIR())
        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)

        '...
        'your codes
        '...
        'hideSubmenu()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)
    End Sub



    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        openChildForm(New FRM_Convert_Image())
        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        'ResetButtonAppearance(PanelSideMenu)
        'Dim clickedButton As Button = DirectCast(sender, Button)
        'active_button(clickedButton)
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        'openChildForm(New TEST())
        'ResetButtonAppearance(PanelSideMenu)
        'Dim clickedButton As Button = DirectCast(sender, Button)
        'active_button(clickedButton)
    End Sub
#End Region


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        Main_Time_today.Interval = 1000
        Main_Time_today.Start()

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel_bar.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel_bar.Visible = True
    End Sub
    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click

        'Dim buttonName As String = clickedButton.Name

        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)
        showSubmenu(PanelToolsSubmenu)
    End Sub
    Private Sub btnRegister_App_Click(sender As Object, e As EventArgs) Handles btnRegister_App.Click
        'openChildForm(New FRM_Register_User())
        'ResetButtonAppearance(PanelSideMenu)


        openChildForm(New FRM_Register())
        ResetButtonAppearance(PanelSideMenu)
        Dim clickedButton As Button = DirectCast(sender, Button)
        active_button(clickedButton)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'openChildForm(New FRM_Register())
        'ResetButtonAppearance(PanelSideMenu)
        'Dim clickedButton As Button = DirectCast(sender, Button)
        'active_button(clickedButton)
    End Sub

    Private Sub Main_Time_today_Tick(sender As Object, e As EventArgs) Handles Main_Time_today.Tick
        Dim currentDate As DateTime = DateTime.Now
        LongDate.Text = currentDate.ToString("dddd, dd MMMM yyyy")
        ToDayTime.Text = currentDate.ToString("HH:mm:ss")
    End Sub

End Class
