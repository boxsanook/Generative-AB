﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Crop_Image
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Crop_Image))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ImageListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Com_Zoom = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBoxDpi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_OutputPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_SourcePath = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Skip_existing_files = New System.Windows.Forms.CheckBox()
        Me.LoadImage = New System.Windows.Forms.Button()
        Me.SaveTo = New System.Windows.Forms.Button()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MeText = New System.Windows.Forms.Label()
        Me.MeClose = New System.Windows.Forms.Button()
        Me.PanelPlayer = New System.Windows.Forms.Panel()
        Me.wk_text = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPlayer.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.ImageListBox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(24, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(863, 254)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Import File "
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
        Me.ImageListBox.Size = New System.Drawing.Size(857, 233)
        Me.ImageListBox.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Skip_existing_files)
        Me.GroupBox2.Controls.Add(Me.LoadImage)
        Me.GroupBox2.Controls.Add(Me.SaveTo)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(24, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(863, 196)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.Com_Zoom)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(390, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 30)
        Me.Panel4.TabIndex = 47
        '
        'Com_Zoom
        '
        Me.Com_Zoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Com_Zoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Com_Zoom.FormattingEnabled = True
        Me.Com_Zoom.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Com_Zoom.Location = New System.Drawing.Point(142, 0)
        Me.Com_Zoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Com_Zoom.Name = "Com_Zoom"
        Me.Com_Zoom.Size = New System.Drawing.Size(190, 28)
        Me.Com_Zoom.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "zoom in detail :"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.ComboBoxDpi)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(34, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 30)
        Me.Panel3.TabIndex = 46
        '
        'ComboBoxDpi
        '
        Me.ComboBoxDpi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxDpi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxDpi.FormattingEnabled = True
        Me.ComboBoxDpi.Items.AddRange(New Object() {".png", ".jpg", ".jpeg"})
        Me.ComboBoxDpi.Location = New System.Drawing.Point(141, 0)
        Me.ComboBoxDpi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxDpi.Name = "ComboBoxDpi"
        Me.ComboBoxDpi.Size = New System.Drawing.Size(191, 28)
        Me.ComboBoxDpi.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 25)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "   Initialize Dpi :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txt_OutputPath)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(47, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(662, 35)
        Me.Panel2.TabIndex = 31
        '
        'txt_OutputPath
        '
        Me.txt_OutputPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_OutputPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OutputPath.Location = New System.Drawing.Point(127, 0)
        Me.txt_OutputPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_OutputPath.Name = "txt_OutputPath"
        Me.txt_OutputPath.Size = New System.Drawing.Size(535, 30)
        Me.txt_OutputPath.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Output Path :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txt_SourcePath)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(42, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 35)
        Me.Panel1.TabIndex = 30
        '
        'txt_SourcePath
        '
        Me.txt_SourcePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SourcePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SourcePath.Location = New System.Drawing.Point(136, 0)
        Me.txt_SourcePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SourcePath.Name = "txt_SourcePath"
        Me.txt_SourcePath.Size = New System.Drawing.Size(531, 30)
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
        Me.Label6.Size = New System.Drawing.Size(136, 25)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Source Path : "
        '
        'Skip_existing_files
        '
        Me.Skip_existing_files.AutoSize = True
        Me.Skip_existing_files.Checked = True
        Me.Skip_existing_files.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Skip_existing_files.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Skip_existing_files.Location = New System.Drawing.Point(173, 144)
        Me.Skip_existing_files.Name = "Skip_existing_files"
        Me.Skip_existing_files.Size = New System.Drawing.Size(193, 28)
        Me.Skip_existing_files.TabIndex = 43
        Me.Skip_existing_files.Text = "Skip existing files"
        Me.Skip_existing_files.UseVisualStyleBackColor = True
        '
        'LoadImage
        '
        Me.LoadImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadImage.BackColor = System.Drawing.Color.Teal
        Me.LoadImage.FlatAppearance.BorderSize = 0
        Me.LoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadImage.ForeColor = System.Drawing.Color.LightGray
        Me.LoadImage.Location = New System.Drawing.Point(732, 17)
        Me.LoadImage.Margin = New System.Windows.Forms.Padding(4)
        Me.LoadImage.Name = "LoadImage"
        Me.LoadImage.Size = New System.Drawing.Size(124, 35)
        Me.LoadImage.TabIndex = 41
        Me.LoadImage.Text = "Load Image"
        Me.LoadImage.UseVisualStyleBackColor = False
        '
        'SaveTo
        '
        Me.SaveTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveTo.BackColor = System.Drawing.Color.Teal
        Me.SaveTo.FlatAppearance.BorderSize = 0
        Me.SaveTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTo.ForeColor = System.Drawing.Color.LightGray
        Me.SaveTo.Location = New System.Drawing.Point(732, 64)
        Me.SaveTo.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveTo.Name = "SaveTo"
        Me.SaveTo.Size = New System.Drawing.Size(124, 35)
        Me.SaveTo.TabIndex = 29
        Me.SaveTo.Text = "Brow Folder"
        Me.SaveTo.UseVisualStyleBackColor = False
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
        Me.BarraTitulo.Size = New System.Drawing.Size(899, 47)
        Me.BarraTitulo.TabIndex = 22
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
        Me.MeText.Size = New System.Drawing.Size(215, 25)
        Me.MeText.TabIndex = 15
        Me.MeText.Text = "Crop Image Application"
        '
        'MeClose
        '
        Me.MeClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MeClose.FlatAppearance.BorderSize = 0
        Me.MeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MeClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MeClose.ForeColor = System.Drawing.Color.Red
        Me.MeClose.Location = New System.Drawing.Point(850, 0)
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
        Me.PanelPlayer.Controls.Add(Me.wk_text)
        Me.PanelPlayer.Controls.Add(Me.btnStart)
        Me.PanelPlayer.Controls.Add(Me.btnStop)
        Me.PanelPlayer.Controls.Add(Me.ProgressBar1)
        Me.PanelPlayer.Controls.Add(Me.label2)
        Me.PanelPlayer.Controls.Add(Me.label1)
        Me.PanelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPlayer.Location = New System.Drawing.Point(0, 516)
        Me.PanelPlayer.Name = "PanelPlayer"
        Me.PanelPlayer.Size = New System.Drawing.Size(899, 99)
        Me.PanelPlayer.TabIndex = 21
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
        Me.ProgressBar1.Size = New System.Drawing.Size(748, 17)
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
        Me.label1.Location = New System.Drawing.Point(850, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 17)
        Me.label1.TabIndex = 9
        Me.label1.Text = "00:00"
        '
        'FRM_Crop_Image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 615)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.PanelPlayer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Crop_Image"
        Me.Text = "Crop Image Application"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPlayer.ResumeLayout(False)
        Me.PanelPlayer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ImageListBox As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents LoadImage As Button
    Private WithEvents txt_SourcePath As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents Com_Zoom As ComboBox
    Private WithEvents Label5 As Label
    Private WithEvents SaveTo As Button
    Private WithEvents txt_OutputPath As TextBox
    Private WithEvents Label3 As Label
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
    Friend WithEvents Skip_existing_files As CheckBox
    Friend WithEvents ComboBoxDpi As ComboBox
    Private WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents wk_text As Label
End Class
