<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Convert_Image
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Convert_Image))
        Me.PanelPlayer = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelPlayer.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPlayer
        '
        Me.PanelPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PanelPlayer.Controls.Add(Me.label3)
        Me.PanelPlayer.Controls.Add(Me.panel4)
        Me.PanelPlayer.Controls.Add(Me.label2)
        Me.PanelPlayer.Controls.Add(Me.label1)
        Me.PanelPlayer.Controls.Add(Me.panel2)
        Me.PanelPlayer.Controls.Add(Me.pictureBox8)
        Me.PanelPlayer.Controls.Add(Me.pictureBox7)
        Me.PanelPlayer.Controls.Add(Me.pictureBox6)
        Me.PanelPlayer.Controls.Add(Me.pictureBox5)
        Me.PanelPlayer.Controls.Add(Me.pictureBox4)
        Me.PanelPlayer.Controls.Add(Me.pictureBox3)
        Me.PanelPlayer.Controls.Add(Me.pictureBox2)
        Me.PanelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPlayer.Location = New System.Drawing.Point(0, 428)
        Me.PanelPlayer.Name = "PanelPlayer"
        Me.PanelPlayer.Size = New System.Drawing.Size(937, 130)
        Me.PanelPlayer.TabIndex = 2
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.LightGray
        Me.label3.Location = New System.Drawing.Point(721, 36)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(28, 17)
        Me.label3.TabIndex = 11
        Me.label3.Text = "0%"
        '
        'panel4
        '
        Me.panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panel4.Controls.Add(Me.panel5)
        Me.panel4.Location = New System.Drawing.Point(515, 42)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(200, 5)
        Me.panel4.TabIndex = 10
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panel5.Location = New System.Drawing.Point(0, -13)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(564, 5)
        Me.panel5.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.LightGray
        Me.label2.Location = New System.Drawing.Point(12, 84)
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
        Me.label1.Location = New System.Drawing.Point(881, 84)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 17)
        Me.label1.TabIndex = 9
        Me.label1.Text = "00:00"
        '
        'panel2
        '
        Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panel2.Controls.Add(Me.panel3)
        Me.panel2.Location = New System.Drawing.Point(58, 91)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(817, 5)
        Me.panel2.TabIndex = 8
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panel3.Location = New System.Drawing.Point(0, -13)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(564, 5)
        Me.panel3.TabIndex = 9
        '
        'pictureBox8
        '
        Me.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox8.Image = CType(resources.GetObject("pictureBox8.Image"), System.Drawing.Image)
        Me.pictureBox8.Location = New System.Drawing.Point(485, 33)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox8.TabIndex = 7
        Me.pictureBox8.TabStop = False
        '
        'pictureBox7
        '
        Me.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox7.Image = CType(resources.GetObject("pictureBox7.Image"), System.Drawing.Image)
        Me.pictureBox7.Location = New System.Drawing.Point(209, 33)
        Me.pictureBox7.Name = "pictureBox7"
        Me.pictureBox7.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox7.TabIndex = 6
        Me.pictureBox7.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image)
        Me.pictureBox6.Location = New System.Drawing.Point(254, 33)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox6.TabIndex = 5
        Me.pictureBox6.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox5.Image = CType(resources.GetObject("pictureBox5.Image"), System.Drawing.Image)
        Me.pictureBox5.Location = New System.Drawing.Point(446, 33)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox5.TabIndex = 4
        Me.pictureBox5.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(296, 33)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox4.TabIndex = 3
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(405, 33)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox3.TabIndex = 2
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(347, 29)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 1
        Me.pictureBox2.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrar.Location = New System.Drawing.Point(895, 4)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FRM_Convert_Image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(937, 558)
        Me.Controls.Add(Me.PanelPlayer)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Name = "FRM_Convert_Image"
        Me.Text = "FRM_Convert_Image"
        Me.PanelPlayer.ResumeLayout(False)
        Me.PanelPlayer.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PanelPlayer As Panel
    Private WithEvents label3 As Label
    Private WithEvents panel4 As Panel
    Private WithEvents panel5 As Panel
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents panel3 As Panel
    Private WithEvents pictureBox8 As PictureBox
    Private WithEvents pictureBox7 As PictureBox
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents BtnCerrar As Button
End Class
