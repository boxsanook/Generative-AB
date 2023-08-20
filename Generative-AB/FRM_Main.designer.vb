<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Main))
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRegister_App = New System.Windows.Forms.Button()
        Me.PanelToolsSubmenu = New System.Windows.Forms.Panel()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.PanelMediaSubmenu = New System.Windows.Forms.Panel()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel_bar = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.LongDate = New System.Windows.Forms.Label()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ToDayTime = New System.Windows.Forms.Label()
        Me.Main_Time_today = New System.Windows.Forms.Timer(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelToolsSubmenu.SuspendLayout()
        Me.PanelMediaSubmenu.SuspendLayout()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_bar.SuspendLayout()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.pictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(248, 92)
        Me.panelLogo.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(241, 83)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'button5
        '
        Me.button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.ForeColor = System.Drawing.Color.Silver
        Me.button5.Location = New System.Drawing.Point(0, 120)
        Me.button5.Name = "button5"
        Me.button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button5.Size = New System.Drawing.Size(248, 40)
        Me.button5.TabIndex = 3
        Me.button5.Text = "Open recent media"
        Me.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.button4.FlatAppearance.BorderSize = 0
        Me.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.ForeColor = System.Drawing.Color.Silver
        Me.button4.Location = New System.Drawing.Point(0, 80)
        Me.button4.Name = "button4"
        Me.button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button4.Size = New System.Drawing.Size(248, 40)
        Me.button4.TabIndex = 2
        Me.button4.Text = "Open Disk"
        Me.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.ForeColor = System.Drawing.Color.Silver
        Me.button3.Location = New System.Drawing.Point(0, 40)
        Me.button3.Name = "button3"
        Me.button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button3.Size = New System.Drawing.Size(248, 40)
        Me.button3.TabIndex = 1
        Me.button3.Text = "Open folder"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.Color.Silver
        Me.button2.Location = New System.Drawing.Point(0, 0)
        Me.button2.Name = "button2"
        Me.button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button2.Size = New System.Drawing.Size(248, 40)
        Me.button2.TabIndex = 0
        Me.button2.Text = "Open files"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.UseVisualStyleBackColor = True
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.Button1)
        Me.PanelSideMenu.Controls.Add(Me.btnExit)
        Me.PanelSideMenu.Controls.Add(Me.btnRegister_App)
        Me.PanelSideMenu.Controls.Add(Me.PanelToolsSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnTools)
        Me.PanelSideMenu.Controls.Add(Me.PanelMediaSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnMedia)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Controls.Add(Me.Panel1)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 713)
        Me.PanelSideMenu.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(248, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "  Help"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Silver
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 668)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(248, 45)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "  Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRegister_App
        '
        Me.btnRegister_App.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegister_App.FlatAppearance.BorderSize = 0
        Me.btnRegister_App.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnRegister_App.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRegister_App.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister_App.ForeColor = System.Drawing.Color.Silver
        Me.btnRegister_App.Image = CType(resources.GetObject("btnRegister_App.Image"), System.Drawing.Image)
        Me.btnRegister_App.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister_App.Location = New System.Drawing.Point(0, 477)
        Me.btnRegister_App.Name = "btnRegister_App"
        Me.btnRegister_App.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnRegister_App.Size = New System.Drawing.Size(248, 45)
        Me.btnRegister_App.TabIndex = 8
        Me.btnRegister_App.Text = "  Register App"
        Me.btnRegister_App.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister_App.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister_App.UseVisualStyleBackColor = True
        '
        'PanelToolsSubmenu
        '
        Me.PanelToolsSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelToolsSubmenu.Controls.Add(Me.button10)
        Me.PanelToolsSubmenu.Controls.Add(Me.button12)
        Me.PanelToolsSubmenu.Controls.Add(Me.button13)
        Me.PanelToolsSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolsSubmenu.Location = New System.Drawing.Point(0, 347)
        Me.PanelToolsSubmenu.Name = "PanelToolsSubmenu"
        Me.PanelToolsSubmenu.Size = New System.Drawing.Size(248, 130)
        Me.PanelToolsSubmenu.TabIndex = 7
        '
        'button10
        '
        Me.button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.button10.FlatAppearance.BorderSize = 0
        Me.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button10.ForeColor = System.Drawing.Color.Silver
        Me.button10.Location = New System.Drawing.Point(0, 80)
        Me.button10.Name = "button10"
        Me.button10.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button10.Size = New System.Drawing.Size(248, 40)
        Me.button10.TabIndex = 2
        Me.button10.Text = "Preferences"
        Me.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button10.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.button12.FlatAppearance.BorderSize = 0
        Me.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button12.ForeColor = System.Drawing.Color.Silver
        Me.button12.Location = New System.Drawing.Point(0, 40)
        Me.button12.Name = "button12"
        Me.button12.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button12.Size = New System.Drawing.Size(248, 40)
        Me.button12.TabIndex = 1
        Me.button12.Text = "Effects and filters"
        Me.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button12.UseVisualStyleBackColor = True
        '
        'button13
        '
        Me.button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.button13.FlatAppearance.BorderSize = 0
        Me.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button13.ForeColor = System.Drawing.Color.Silver
        Me.button13.Location = New System.Drawing.Point(0, 0)
        Me.button13.Name = "button13"
        Me.button13.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button13.Size = New System.Drawing.Size(248, 40)
        Me.button13.TabIndex = 0
        Me.button13.Text = "Media converter"
        Me.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button13.UseVisualStyleBackColor = True
        '
        'btnTools
        '
        Me.btnTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTools.FlatAppearance.BorderSize = 0
        Me.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTools.ForeColor = System.Drawing.Color.Silver
        Me.btnTools.Image = CType(resources.GetObject("btnTools.Image"), System.Drawing.Image)
        Me.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.Location = New System.Drawing.Point(0, 302)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTools.Size = New System.Drawing.Size(248, 45)
        Me.btnTools.TabIndex = 6
        Me.btnTools.Text = "  Tools"
        Me.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTools.UseVisualStyleBackColor = True
        '
        'PanelMediaSubmenu
        '
        Me.PanelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelMediaSubmenu.Controls.Add(Me.button5)
        Me.PanelMediaSubmenu.Controls.Add(Me.button4)
        Me.PanelMediaSubmenu.Controls.Add(Me.button3)
        Me.PanelMediaSubmenu.Controls.Add(Me.button2)
        Me.PanelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediaSubmenu.Location = New System.Drawing.Point(0, 137)
        Me.PanelMediaSubmenu.Name = "PanelMediaSubmenu"
        Me.PanelMediaSubmenu.Size = New System.Drawing.Size(248, 165)
        Me.PanelMediaSubmenu.TabIndex = 2
        '
        'btnMedia
        '
        Me.btnMedia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedia.FlatAppearance.BorderSize = 0
        Me.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedia.ForeColor = System.Drawing.Color.Silver
        Me.btnMedia.Image = CType(resources.GetObject("btnMedia.Image"), System.Drawing.Image)
        Me.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.Location = New System.Drawing.Point(0, 92)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMedia.Size = New System.Drawing.Size(248, 45)
        Me.btnMedia.TabIndex = 1
        Me.btnMedia.Text = "  Media"
        Me.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMedia.UseVisualStyleBackColor = True
        Me.btnMedia.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(248, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 713)
        Me.Panel1.TabIndex = 1
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelChildForm.Controls.Add(Me.Panel_bar)
        Me.PanelChildForm.Controls.Add(Me.PictureBox9)
        Me.PanelChildForm.Controls.Add(Me.Button7)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(996, 713)
        Me.PanelChildForm.TabIndex = 2
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(305, 92)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(478, 430)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'Panel_bar
        '
        Me.Panel_bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel_bar.Controls.Add(Me.Button6)
        Me.Panel_bar.Controls.Add(Me.label4)
        Me.Panel_bar.Controls.Add(Me.label3)
        Me.Panel_bar.Controls.Add(Me.LongDate)
        Me.Panel_bar.Controls.Add(Me.pictureBox7)
        Me.Panel_bar.Controls.Add(Me.ToDayTime)
        Me.Panel_bar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_bar.Location = New System.Drawing.Point(0, 645)
        Me.Panel_bar.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_bar.Name = "Panel_bar"
        Me.Panel_bar.Size = New System.Drawing.Size(996, 68)
        Me.Panel_bar.TabIndex = 7
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(957, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(36, 33)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.label4.ForeColor = System.Drawing.Color.LightGray
        Me.label4.Location = New System.Drawing.Point(78, 30)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(199, 20)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Dev Code By BoxS.me"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.label3.ForeColor = System.Drawing.Color.LightGray
        Me.label3.Location = New System.Drawing.Point(78, 3)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(187, 20)
        Me.label3.TabIndex = 5
        Me.label3.Text = "AB Generative Image"
        '
        'LongDate
        '
        Me.LongDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LongDate.AutoSize = True
        Me.LongDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LongDate.ForeColor = System.Drawing.Color.White
        Me.LongDate.Location = New System.Drawing.Point(734, 40)
        Me.LongDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LongDate.Name = "LongDate"
        Me.LongDate.Size = New System.Drawing.Size(188, 25)
        Me.LongDate.TabIndex = 4
        Me.LongDate.Text = "Lunes, 26 Sep 2018"
        '
        'pictureBox7
        '
        Me.pictureBox7.Image = CType(resources.GetObject("pictureBox7.Image"), System.Drawing.Image)
        Me.pictureBox7.Location = New System.Drawing.Point(5, 3)
        Me.pictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox7.Name = "pictureBox7"
        Me.pictureBox7.Size = New System.Drawing.Size(78, 61)
        Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox7.TabIndex = 3
        Me.pictureBox7.TabStop = False
        '
        'ToDayTime
        '
        Me.ToDayTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToDayTime.AutoSize = True
        Me.ToDayTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDayTime.ForeColor = System.Drawing.Color.LightGray
        Me.ToDayTime.Location = New System.Drawing.Point(750, 3)
        Me.ToDayTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToDayTime.Name = "ToDayTime"
        Me.ToDayTime.Size = New System.Drawing.Size(149, 39)
        Me.ToDayTime.TabIndex = 1
        Me.ToDayTime.Text = "21:49:45"
        '
        'Main_Time_today
        '
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(957, 678)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(36, 33)
        Me.Button7.TabIndex = 10
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FRM_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 713)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "FRM_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AB Generative Image"
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelToolsSubmenu.ResumeLayout(False)
        Me.PanelMediaSubmenu.ResumeLayout(False)
        Me.PanelChildForm.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_bar.ResumeLayout(False)
        Me.Panel_bar.PerformLayout()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelLogo As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents btnExit As Button
    Private WithEvents btnRegister_App As Button
    Private WithEvents PanelToolsSubmenu As Panel
    Private WithEvents button10 As Button
    Private WithEvents button12 As Button
    Private WithEvents button13 As Button
    Private WithEvents btnTools As Button
    Private WithEvents PanelMediaSubmenu As Panel
    Private WithEvents btnMedia As Button
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents Button1 As Button
    Private WithEvents Panel_bar As Panel
    Friend WithEvents Button6 As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents LongDate As Label
    Private WithEvents pictureBox7 As PictureBox
    Private WithEvents ToDayTime As Label
    Friend WithEvents Main_Time_today As Timer
    Friend WithEvents Button7 As Button
End Class
