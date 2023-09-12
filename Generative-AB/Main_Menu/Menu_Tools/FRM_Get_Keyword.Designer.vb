<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Get_Keyword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Get_Keyword))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ImageListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_SourcePath = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LoadImage = New System.Windows.Forms.Button()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MeText = New System.Windows.Forms.Label()
        Me.MeClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataExcell = New System.Windows.Forms.DataGridView()
        Me.PanelPlayer = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExportToExcel = New System.Windows.Forms.Button()
        Me.wk_text = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataExcell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPlayer.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.ImageListBox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(18, 136)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(935, 184)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Source Import File :"
        '
        'ImageListBox
        '
        Me.ImageListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ImageListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageListBox.ForeColor = System.Drawing.Color.White
        Me.ImageListBox.FormattingEnabled = True
        Me.ImageListBox.ItemHeight = 16
        Me.ImageListBox.Location = New System.Drawing.Point(3, 18)
        Me.ImageListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImageListBox.Name = "ImageListBox"
        Me.ImageListBox.Size = New System.Drawing.Size(929, 163)
        Me.ImageListBox.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.LoadImage)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(18, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(935, 77)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txt_SourcePath)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(16, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 29)
        Me.Panel1.TabIndex = 44
        '
        'txt_SourcePath
        '
        Me.txt_SourcePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SourcePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SourcePath.Location = New System.Drawing.Point(131, 0)
        Me.txt_SourcePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SourcePath.Name = "txt_SourcePath"
        Me.txt_SourcePath.Size = New System.Drawing.Size(635, 30)
        Me.txt_SourcePath.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 25)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Source Path :"
        '
        'LoadImage
        '
        Me.LoadImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadImage.BackColor = System.Drawing.Color.Teal
        Me.LoadImage.FlatAppearance.BorderSize = 0
        Me.LoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadImage.ForeColor = System.Drawing.Color.LightGray
        Me.LoadImage.Location = New System.Drawing.Point(804, 20)
        Me.LoadImage.Margin = New System.Windows.Forms.Padding(4)
        Me.LoadImage.Name = "LoadImage"
        Me.LoadImage.Size = New System.Drawing.Size(124, 35)
        Me.LoadImage.TabIndex = 41
        Me.LoadImage.Text = "Load Image"
        Me.LoadImage.UseVisualStyleBackColor = False
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
        Me.BarraTitulo.Size = New System.Drawing.Size(965, 47)
        Me.BarraTitulo.TabIndex = 21
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
        Me.MeText.Size = New System.Drawing.Size(212, 25)
        Me.MeText.TabIndex = 15
        Me.MeText.Text = "Get Keyword By Image"
        '
        'MeClose
        '
        Me.MeClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MeClose.FlatAppearance.BorderSize = 0
        Me.MeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MeClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MeClose.ForeColor = System.Drawing.Color.Red
        Me.MeClose.Location = New System.Drawing.Point(916, 0)
        Me.MeClose.Margin = New System.Windows.Forms.Padding(4)
        Me.MeClose.Name = "MeClose"
        Me.MeClose.Size = New System.Drawing.Size(51, 47)
        Me.MeClose.TabIndex = 4
        Me.MeClose.Text = "X"
        Me.MeClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataExcell)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(18, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 153)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Import File :"
        '
        'DataExcell
        '
        Me.DataExcell.AllowUserToAddRows = False
        Me.DataExcell.AllowUserToDeleteRows = False
        Me.DataExcell.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataExcell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataExcell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataExcell.GridColor = System.Drawing.Color.Gray
        Me.DataExcell.Location = New System.Drawing.Point(3, 18)
        Me.DataExcell.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataExcell.Name = "DataExcell"
        Me.DataExcell.ReadOnly = True
        Me.DataExcell.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataExcell.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataExcell.RowTemplate.Height = 24
        Me.DataExcell.Size = New System.Drawing.Size(929, 132)
        Me.DataExcell.TabIndex = 9
        '
        'PanelPlayer
        '
        Me.PanelPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PanelPlayer.Controls.Add(Me.TextBox1)
        Me.PanelPlayer.Controls.Add(Me.Button1)
        Me.PanelPlayer.Controls.Add(Me.ExportToExcel)
        Me.PanelPlayer.Controls.Add(Me.wk_text)
        Me.PanelPlayer.Controls.Add(Me.btnStart)
        Me.PanelPlayer.Controls.Add(Me.btnStop)
        Me.PanelPlayer.Controls.Add(Me.ProgressBar1)
        Me.PanelPlayer.Controls.Add(Me.label2)
        Me.PanelPlayer.Controls.Add(Me.label1)
        Me.PanelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPlayer.Location = New System.Drawing.Point(0, 499)
        Me.PanelPlayer.Name = "PanelPlayer"
        Me.PanelPlayer.Size = New System.Drawing.Size(965, 90)
        Me.PanelPlayer.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(417, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 22)
        Me.TextBox1.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExportToExcel
        '
        Me.ExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportToExcel.BackColor = System.Drawing.Color.Green
        Me.ExportToExcel.FlatAppearance.BorderSize = 2
        Me.ExportToExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExportToExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ExportToExcel.ForeColor = System.Drawing.Color.White
        Me.ExportToExcel.Location = New System.Drawing.Point(742, 41)
        Me.ExportToExcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExportToExcel.Name = "ExportToExcel"
        Me.ExportToExcel.Size = New System.Drawing.Size(168, 33)
        Me.ExportToExcel.TabIndex = 52
        Me.ExportToExcel.Tag = "Start"
        Me.ExportToExcel.Text = "Export To Excel"
        Me.ExportToExcel.UseVisualStyleBackColor = False
        '
        'wk_text
        '
        Me.wk_text.AutoSize = True
        Me.wk_text.ForeColor = System.Drawing.Color.White
        Me.wk_text.Location = New System.Drawing.Point(204, 38)
        Me.wk_text.Name = "wk_text"
        Me.wk_text.Size = New System.Drawing.Size(0, 17)
        Me.wk_text.TabIndex = 16
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(92, 38)
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
        Me.btnStop.Location = New System.Drawing.Point(141, 38)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(43, 40)
        Me.btnStop.TabIndex = 13
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(96, 15)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(814, 17)
        Me.ProgressBar1.TabIndex = 12
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.LightGray
        Me.label2.Location = New System.Drawing.Point(21, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 17)
        Me.label2.TabIndex = 10
        Me.label2.Text = "00:00"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.LightGray
        Me.label1.Location = New System.Drawing.Point(916, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 17)
        Me.label1.TabIndex = 9
        Me.label1.Text = "00:00"
        '
        'FRM_Get_Keyword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 589)
        Me.Controls.Add(Me.PanelPlayer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Name = "FRM_Get_Keyword"
        Me.Text = "FRM_Get_Keyword"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataExcell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPlayer.ResumeLayout(False)
        Me.PanelPlayer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ImageListBox As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents txt_SourcePath As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents LoadImage As Button
    Private WithEvents BarraTitulo As Panel
    Private WithEvents PictureBox1 As PictureBox
    Public WithEvents MeText As Label
    Private WithEvents MeClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents PanelPlayer As Panel
    Friend WithEvents wk_text As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents DataExcell As DataGridView
    Friend WithEvents ExportToExcel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
