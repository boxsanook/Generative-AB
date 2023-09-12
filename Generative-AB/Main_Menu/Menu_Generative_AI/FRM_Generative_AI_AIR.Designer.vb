<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Generative_AI_AIR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Generative_AI_AIR))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MeText = New System.Windows.Forms.Label()
        Me.MeClose = New System.Windows.Forms.Button()
        Me.PanelPlayer = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_sell_on = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_complexities = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExportTemplate = New System.Windows.Forms.Button()
        Me.btn_LoadExcel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_Excel = New System.Windows.Forms.TextBox()
        Me.BT_Celar_All = New System.Windows.Forms.Button()
        Me.lbl_AccessToken = New System.Windows.Forms.Label()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListImage_type = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataExcell = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPlayer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataExcell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.PictureBox1)
        Me.BarraTitulo.Controls.Add(Me.MeText)
        Me.BarraTitulo.Controls.Add(Me.MeClose)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1301, 47)
        Me.BarraTitulo.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'MeText
        '
        Me.MeText.AutoSize = True
        Me.MeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeText.ForeColor = System.Drawing.Color.White
        Me.MeText.Location = New System.Drawing.Point(69, 14)
        Me.MeText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MeText.Name = "MeText"
        Me.MeText.Size = New System.Drawing.Size(132, 25)
        Me.MeText.TabIndex = 15
        Me.MeText.Text = "generative AI "
        '
        'MeClose
        '
        Me.MeClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MeClose.FlatAppearance.BorderSize = 0
        Me.MeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MeClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MeClose.ForeColor = System.Drawing.Color.Red
        Me.MeClose.Location = New System.Drawing.Point(1252, 0)
        Me.MeClose.Margin = New System.Windows.Forms.Padding(4)
        Me.MeClose.Name = "MeClose"
        Me.MeClose.Size = New System.Drawing.Size(51, 47)
        Me.MeClose.TabIndex = 4
        Me.MeClose.Text = "X"
        Me.MeClose.UseVisualStyleBackColor = True
        '
        'PanelPlayer
        '
        Me.PanelPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PanelPlayer.Controls.Add(Me.btnStart)
        Me.PanelPlayer.Controls.Add(Me.btnStop)
        Me.PanelPlayer.Controls.Add(Me.ProgressBar1)
        Me.PanelPlayer.Controls.Add(Me.label2)
        Me.PanelPlayer.Controls.Add(Me.label1)
        Me.PanelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPlayer.Location = New System.Drawing.Point(0, 584)
        Me.PanelPlayer.Name = "PanelPlayer"
        Me.PanelPlayer.Size = New System.Drawing.Size(1301, 93)
        Me.PanelPlayer.TabIndex = 24
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(576, 45)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(43, 40)
        Me.btnStart.TabIndex = 14
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = CType(resources.GetObject("btnStop.BackgroundImage"), System.Drawing.Image)
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(625, 45)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(43, 40)
        Me.btnStop.TabIndex = 13
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(310, 13)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(832, 28)
        Me.ProgressBar1.TabIndex = 12
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.label2.ForeColor = System.Drawing.Color.LightGray
        Me.label2.Location = New System.Drawing.Point(249, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 24)
        Me.label2.TabIndex = 10
        Me.label2.Text = "00:00"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.label1.ForeColor = System.Drawing.Color.LightGray
        Me.label1.Location = New System.Drawing.Point(1148, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 24)
        Me.label1.TabIndex = 9
        Me.label1.Text = "00:00"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.txt_sell_on)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_complexities)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ExportTemplate)
        Me.GroupBox2.Controls.Add(Me.btn_LoadExcel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXT_Excel)
        Me.GroupBox2.Controls.Add(Me.BT_Celar_All)
        Me.GroupBox2.Controls.Add(Me.lbl_AccessToken)
        Me.GroupBox2.Controls.Add(Me.txtToken)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ListImage_type)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(24, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1265, 274)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Remix Style :"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 188)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(396, 68)
        Me.ListBox1.TabIndex = 57
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(459, 219)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(493, 48)
        Me.TextBox1.TabIndex = 56
        '
        'txt_sell_on
        '
        Me.txt_sell_on.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sell_on.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_sell_on.Enabled = False
        Me.txt_sell_on.FormattingEnabled = True
        Me.txt_sell_on.Items.AddRange(New Object() {"miricanvas", "dreamstime"})
        Me.txt_sell_on.Location = New System.Drawing.Point(773, 188)
        Me.txt_sell_on.Name = "txt_sell_on"
        Me.txt_sell_on.Size = New System.Drawing.Size(179, 24)
        Me.txt_sell_on.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(696, 188)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Sell on :"
        '
        'txt_complexities
        '
        Me.txt_complexities.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_complexities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_complexities.FormattingEnabled = True
        Me.txt_complexities.Items.AddRange(New Object() {"-1", "0", "1", "2", "3", "4"})
        Me.txt_complexities.Location = New System.Drawing.Point(585, 188)
        Me.txt_complexities.Name = "txt_complexities"
        Me.txt_complexities.Size = New System.Drawing.Size(82, 24)
        Me.txt_complexities.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(455, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Level of detail :"
        '
        'ExportTemplate
        '
        Me.ExportTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportTemplate.BackColor = System.Drawing.Color.Green
        Me.ExportTemplate.FlatAppearance.BorderSize = 2
        Me.ExportTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExportTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExportTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ExportTemplate.ForeColor = System.Drawing.Color.White
        Me.ExportTemplate.Location = New System.Drawing.Point(1128, 128)
        Me.ExportTemplate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExportTemplate.Name = "ExportTemplate"
        Me.ExportTemplate.Size = New System.Drawing.Size(130, 40)
        Me.ExportTemplate.TabIndex = 51
        Me.ExportTemplate.Text = "Get Template"
        Me.ExportTemplate.UseVisualStyleBackColor = False
        '
        'btn_LoadExcel
        '
        Me.btn_LoadExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LoadExcel.BackColor = System.Drawing.Color.Green
        Me.btn_LoadExcel.FlatAppearance.BorderSize = 2
        Me.btn_LoadExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_LoadExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_LoadExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LoadExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_LoadExcel.ForeColor = System.Drawing.Color.White
        Me.btn_LoadExcel.Location = New System.Drawing.Point(1068, 128)
        Me.btn_LoadExcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LoadExcel.Name = "btn_LoadExcel"
        Me.btn_LoadExcel.Size = New System.Drawing.Size(54, 40)
        Me.btn_LoadExcel.TabIndex = 50
        Me.btn_LoadExcel.Text = "..."
        Me.btn_LoadExcel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(455, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Load Prompt Template :"
        '
        'TXT_Excel
        '
        Me.TXT_Excel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Excel.Location = New System.Drawing.Point(459, 128)
        Me.TXT_Excel.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Excel.Multiline = True
        Me.TXT_Excel.Name = "TXT_Excel"
        Me.TXT_Excel.ReadOnly = True
        Me.TXT_Excel.Size = New System.Drawing.Size(602, 40)
        Me.TXT_Excel.TabIndex = 48
        '
        'BT_Celar_All
        '
        Me.BT_Celar_All.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Celar_All.BackColor = System.Drawing.Color.Red
        Me.BT_Celar_All.FlatAppearance.BorderSize = 2
        Me.BT_Celar_All.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BT_Celar_All.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_Celar_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Celar_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BT_Celar_All.ForeColor = System.Drawing.Color.White
        Me.BT_Celar_All.Location = New System.Drawing.Point(1090, 53)
        Me.BT_Celar_All.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_Celar_All.Name = "BT_Celar_All"
        Me.BT_Celar_All.Size = New System.Drawing.Size(168, 40)
        Me.BT_Celar_All.TabIndex = 47
        Me.BT_Celar_All.Text = "Get Token"
        Me.BT_Celar_All.UseVisualStyleBackColor = False
        '
        'lbl_AccessToken
        '
        Me.lbl_AccessToken.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_AccessToken.AutoSize = True
        Me.lbl_AccessToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AccessToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lbl_AccessToken.Location = New System.Drawing.Point(455, 29)
        Me.lbl_AccessToken.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_AccessToken.Name = "lbl_AccessToken"
        Me.lbl_AccessToken.Size = New System.Drawing.Size(125, 20)
        Me.lbl_AccessToken.TabIndex = 46
        Me.lbl_AccessToken.Text = "Access Token :"
        '
        'txtToken
        '
        Me.txtToken.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToken.Location = New System.Drawing.Point(459, 53)
        Me.txtToken.Margin = New System.Windows.Forms.Padding(4)
        Me.txtToken.Multiline = True
        Me.txtToken.Name = "txtToken"
        Me.txtToken.ReadOnly = True
        Me.txtToken.Size = New System.Drawing.Size(624, 40)
        Me.txtToken.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(7, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Image Style :"
        '
        'ListImage_type
        '
        Me.ListImage_type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListImage_type.FormattingEnabled = True
        Me.ListImage_type.ItemHeight = 16
        Me.ListImage_type.Location = New System.Drawing.Point(6, 53)
        Me.ListImage_type.Name = "ListImage_type"
        Me.ListImage_type.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListImage_type.Size = New System.Drawing.Size(396, 100)
        Me.ListImage_type.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DataExcell)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(24, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1265, 231)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prompt :"
        '
        'DataExcell
        '
        Me.DataExcell.AllowUserToAddRows = False
        Me.DataExcell.AllowUserToDeleteRows = False
        Me.DataExcell.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataExcell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataExcell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataExcell.GridColor = System.Drawing.Color.Gray
        Me.DataExcell.Location = New System.Drawing.Point(3, 23)
        Me.DataExcell.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataExcell.Name = "DataExcell"
        Me.DataExcell.ReadOnly = True
        Me.DataExcell.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataExcell.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataExcell.RowTemplate.Height = 24
        Me.DataExcell.Size = New System.Drawing.Size(1259, 205)
        Me.DataExcell.TabIndex = 8
        '
        'FRM_Generative_AI_AIR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1301, 677)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PanelPlayer)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Generative_AI_AIR"
        Me.Text = "Generative AI"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPlayer.ResumeLayout(False)
        Me.PanelPlayer.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataExcell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BarraTitulo As Panel
    Private WithEvents PictureBox1 As PictureBox
    Public WithEvents MeText As Label
    Private WithEvents MeClose As Button
    Private WithEvents PanelPlayer As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Private WithEvents Label6 As Label
    Friend WithEvents ListImage_type As ListBox
    Private WithEvents lbl_AccessToken As Label
    Private WithEvents txtToken As TextBox
    Friend WithEvents BT_Celar_All As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ExportTemplate As Button
    Friend WithEvents btn_LoadExcel As Button
    Private WithEvents Label3 As Label
    Private WithEvents TXT_Excel As TextBox
    Friend WithEvents DataExcell As DataGridView
    Friend WithEvents txt_complexities As ComboBox
    Private WithEvents Label4 As Label
    Friend WithEvents txt_sell_on As ComboBox
    Private WithEvents Label5 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
