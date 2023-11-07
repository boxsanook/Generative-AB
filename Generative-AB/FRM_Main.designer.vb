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
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.PanelHelp = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Panel_Config = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSubRegisterApp = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PanelToolsSubmenu = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btn_ResizeSVG = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.PanelMediaSubmenu = New System.Windows.Forms.Panel()
        Me.btnMenuAi = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.Panel_bar = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.LongDate = New System.Windows.Forms.Label()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ToDayTime = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Main_Time_today = New System.Windows.Forms.Timer(Me.components)
        Me.MaxSize = New System.Windows.Forms.Timer(Me.components)
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelHelp.SuspendLayout()
        Me.Panel_Config.SuspendLayout()
        Me.PanelToolsSubmenu.SuspendLayout()
        Me.PanelMediaSubmenu.SuspendLayout()
        Me.PanelChildForm.SuspendLayout()
        Me.Panel_bar.SuspendLayout()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.pictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(227, 92)
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
        Me.button4.Size = New System.Drawing.Size(227, 40)
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
        Me.button3.Size = New System.Drawing.Size(227, 40)
        Me.button3.TabIndex = 1
        Me.button3.Text = "Promt Community "
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
        Me.button2.Size = New System.Drawing.Size(227, 40)
        Me.button2.TabIndex = 0
        Me.button2.Text = "AI Generative AB "
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.UseVisualStyleBackColor = True
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.PanelHelp)
        Me.PanelSideMenu.Controls.Add(Me.btnHelp)
        Me.PanelSideMenu.Controls.Add(Me.Panel_Config)
        Me.PanelSideMenu.Controls.Add(Me.btnSettings)
        Me.PanelSideMenu.Controls.Add(Me.btnExit)
        Me.PanelSideMenu.Controls.Add(Me.PanelToolsSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnTools)
        Me.PanelSideMenu.Controls.Add(Me.PanelMediaSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnMenuAi)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Controls.Add(Me.Panel1)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 713)
        Me.PanelSideMenu.TabIndex = 0
        '
        'PanelHelp
        '
        Me.PanelHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelHelp.Controls.Add(Me.btnAbout)
        Me.PanelHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHelp.Location = New System.Drawing.Point(0, 731)
        Me.PanelHelp.Name = "PanelHelp"
        Me.PanelHelp.Size = New System.Drawing.Size(227, 51)
        Me.PanelHelp.TabIndex = 13
        '
        'btnAbout
        '
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.Silver
        Me.btnAbout.Location = New System.Drawing.Point(0, 0)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAbout.Size = New System.Drawing.Size(227, 40)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ForeColor = System.Drawing.Color.Silver
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 686)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(227, 45)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "  Help"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Panel_Config
        '
        Me.Panel_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel_Config.Controls.Add(Me.Button1)
        Me.Panel_Config.Controls.Add(Me.btnSubRegisterApp)
        Me.Panel_Config.Controls.Add(Me.btnOptions)
        Me.Panel_Config.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Config.Location = New System.Drawing.Point(0, 557)
        Me.Panel_Config.Name = "Panel_Config"
        Me.Panel_Config.Size = New System.Drawing.Size(227, 129)
        Me.Panel_Config.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(0, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(227, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SQL Setting"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSubRegisterApp
        '
        Me.btnSubRegisterApp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubRegisterApp.FlatAppearance.BorderSize = 0
        Me.btnSubRegisterApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnSubRegisterApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnSubRegisterApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubRegisterApp.ForeColor = System.Drawing.Color.Silver
        Me.btnSubRegisterApp.Location = New System.Drawing.Point(0, 40)
        Me.btnSubRegisterApp.Name = "btnSubRegisterApp"
        Me.btnSubRegisterApp.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSubRegisterApp.Size = New System.Drawing.Size(227, 40)
        Me.btnSubRegisterApp.TabIndex = 1
        Me.btnSubRegisterApp.Text = "Register App"
        Me.btnSubRegisterApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubRegisterApp.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.ForeColor = System.Drawing.Color.Silver
        Me.btnOptions.Location = New System.Drawing.Point(0, 0)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnOptions.Size = New System.Drawing.Size(227, 40)
        Me.btnOptions.TabIndex = 0
        Me.btnOptions.Text = "Options"
        Me.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.ForeColor = System.Drawing.Color.Silver
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 512)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnSettings.Size = New System.Drawing.Size(227, 45)
        Me.btnSettings.TabIndex = 11
        Me.btnSettings.Text = "  Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
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
        Me.btnExit.Location = New System.Drawing.Point(0, 782)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(227, 45)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "  Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PanelToolsSubmenu
        '
        Me.PanelToolsSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelToolsSubmenu.Controls.Add(Me.Button8)
        Me.PanelToolsSubmenu.Controls.Add(Me.btn_ResizeSVG)
        Me.PanelToolsSubmenu.Controls.Add(Me.Button5)
        Me.PanelToolsSubmenu.Controls.Add(Me.button12)
        Me.PanelToolsSubmenu.Controls.Add(Me.button13)
        Me.PanelToolsSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolsSubmenu.Location = New System.Drawing.Point(0, 308)
        Me.PanelToolsSubmenu.Name = "PanelToolsSubmenu"
        Me.PanelToolsSubmenu.Size = New System.Drawing.Size(227, 204)
        Me.PanelToolsSubmenu.TabIndex = 7
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Silver
        Me.Button8.Location = New System.Drawing.Point(0, 160)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(227, 40)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Move FIle to Folder"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btn_ResizeSVG
        '
        Me.btn_ResizeSVG.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ResizeSVG.FlatAppearance.BorderSize = 0
        Me.btn_ResizeSVG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btn_ResizeSVG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btn_ResizeSVG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ResizeSVG.ForeColor = System.Drawing.Color.Silver
        Me.btn_ResizeSVG.Location = New System.Drawing.Point(0, 120)
        Me.btn_ResizeSVG.Name = "btn_ResizeSVG"
        Me.btn_ResizeSVG.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_ResizeSVG.Size = New System.Drawing.Size(227, 40)
        Me.btn_ResizeSVG.TabIndex = 4
        Me.btn_ResizeSVG.Text = "Resize SVG"
        Me.btn_ResizeSVG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ResizeSVG.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Silver
        Me.Button5.Location = New System.Drawing.Point(0, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(227, 40)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Get Keyword"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
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
        Me.button12.Size = New System.Drawing.Size(227, 40)
        Me.button12.TabIndex = 1
        Me.button12.Text = "Crop Image"
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
        Me.button13.Size = New System.Drawing.Size(227, 40)
        Me.button13.TabIndex = 0
        Me.button13.Text = "Converter Image"
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
        Me.btnTools.Location = New System.Drawing.Point(0, 263)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTools.Size = New System.Drawing.Size(227, 45)
        Me.btnTools.TabIndex = 6
        Me.btnTools.Text = "  Media Tools"
        Me.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTools.UseVisualStyleBackColor = True
        '
        'PanelMediaSubmenu
        '
        Me.PanelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelMediaSubmenu.Controls.Add(Me.button4)
        Me.PanelMediaSubmenu.Controls.Add(Me.button3)
        Me.PanelMediaSubmenu.Controls.Add(Me.button2)
        Me.PanelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediaSubmenu.Location = New System.Drawing.Point(0, 137)
        Me.PanelMediaSubmenu.Name = "PanelMediaSubmenu"
        Me.PanelMediaSubmenu.Size = New System.Drawing.Size(227, 126)
        Me.PanelMediaSubmenu.TabIndex = 2
        '
        'btnMenuAi
        '
        Me.btnMenuAi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuAi.FlatAppearance.BorderSize = 0
        Me.btnMenuAi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMenuAi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMenuAi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuAi.ForeColor = System.Drawing.Color.Silver
        Me.btnMenuAi.Image = CType(resources.GetObject("btnMenuAi.Image"), System.Drawing.Image)
        Me.btnMenuAi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuAi.Location = New System.Drawing.Point(0, 92)
        Me.btnMenuAi.Name = "btnMenuAi"
        Me.btnMenuAi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMenuAi.Size = New System.Drawing.Size(227, 45)
        Me.btnMenuAi.TabIndex = 1
        Me.btnMenuAi.Text = "  Generative AI"
        Me.btnMenuAi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuAi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuAi.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(227, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 827)
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
        Me.ToDayTime.Size = New System.Drawing.Size(143, 38)
        Me.ToDayTime.TabIndex = 1
        Me.ToDayTime.Text = "21:49:45"
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
        'Main_Time_today
        '
        '
        'MaxSize
        '
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
        Me.Text = "AB Generative Image Tools"
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelHelp.ResumeLayout(False)
        Me.Panel_Config.ResumeLayout(False)
        Me.PanelToolsSubmenu.ResumeLayout(False)
        Me.PanelMediaSubmenu.ResumeLayout(False)
        Me.PanelChildForm.ResumeLayout(False)
        Me.Panel_bar.ResumeLayout(False)
        Me.Panel_bar.PerformLayout()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelLogo As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents btnExit As Button
    Private WithEvents PanelToolsSubmenu As Panel
    Private WithEvents button12 As Button
    Private WithEvents button13 As Button
    Private WithEvents btnTools As Button
    Private WithEvents PanelMediaSubmenu As Panel
    Private WithEvents btnMenuAi As Button
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents btnHelp As Button
    Private WithEvents Panel_bar As Panel
    Friend WithEvents Button6 As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents LongDate As Label
    Private WithEvents pictureBox7 As PictureBox
    Private WithEvents ToDayTime As Label
    Friend WithEvents Main_Time_today As Timer
    Friend WithEvents Button7 As Button
    Private WithEvents Panel_Config As Panel
    Private WithEvents btnSubRegisterApp As Button
    Private WithEvents btnOptions As Button
    Private WithEvents btnSettings As Button
    Friend WithEvents MaxSize As Timer
    Private WithEvents PanelHelp As Panel
    Private WithEvents btnAbout As Button
    Private WithEvents Button1 As Button
    Private WithEvents Button5 As Button
    Private WithEvents btn_ResizeSVG As Button
    Private WithEvents Button8 As Button
End Class
