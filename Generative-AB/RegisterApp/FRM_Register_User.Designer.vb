<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Register_User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Register_User))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.MeText = New System.Windows.Forms.Label()
        Me.Key = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btc_Register = New System.Windows.Forms.Button()
        Me.P3 = New System.Windows.Forms.Panel()
        Me.RCONFIRMPASSWORD = New System.Windows.Forms.TextBox()
        Me.P2 = New System.Windows.Forms.Panel()
        Me.P1 = New System.Windows.Forms.Panel()
        Me.RPASSWORD = New System.Windows.Forms.TextBox()
        Me.REmail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RUsername = New System.Windows.Forms.TextBox()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.PictureBox1)
        Me.BarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.BarraTitulo.Controls.Add(Me.MeText)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(652, 47)
        Me.BarraTitulo.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrar.Location = New System.Drawing.Point(602, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(51, 47)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'MeText
        '
        Me.MeText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MeText.AutoSize = True
        Me.MeText.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeText.ForeColor = System.Drawing.Color.White
        Me.MeText.Location = New System.Drawing.Point(56, 3)
        Me.MeText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MeText.Name = "MeText"
        Me.MeText.Size = New System.Drawing.Size(474, 40)
        Me.MeText.TabIndex = 41
        Me.MeText.Text = "Register a new membership"
        '
        'Key
        '
        Me.Key.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Key.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Key.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Key.ForeColor = System.Drawing.Color.Silver
        Me.Key.Location = New System.Drawing.Point(13, 276)
        Me.Key.Margin = New System.Windows.Forms.Padding(4)
        Me.Key.Multiline = True
        Me.Key.Name = "Key"
        Me.Key.ReadOnly = True
        Me.Key.Size = New System.Drawing.Size(616, 154)
        Me.Key.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(12, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 28)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "M Code :"
        '
        'btc_Register
        '
        Me.btc_Register.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btc_Register.BackColor = System.Drawing.Color.Transparent
        Me.btc_Register.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btc_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btc_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btc_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btc_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btc_Register.ForeColor = System.Drawing.SystemColors.Menu
        Me.btc_Register.Location = New System.Drawing.Point(488, 448)
        Me.btc_Register.Margin = New System.Windows.Forms.Padding(4)
        Me.btc_Register.Name = "btc_Register"
        Me.btc_Register.Size = New System.Drawing.Size(151, 47)
        Me.btc_Register.TabIndex = 61
        Me.btc_Register.Text = "Register"
        Me.btc_Register.UseVisualStyleBackColor = False
        '
        'P3
        '
        Me.P3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P3.BackColor = System.Drawing.Color.White
        Me.P3.Location = New System.Drawing.Point(13, 226)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(616, 2)
        Me.P3.TabIndex = 57
        '
        'RCONFIRMPASSWORD
        '
        Me.RCONFIRMPASSWORD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RCONFIRMPASSWORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RCONFIRMPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RCONFIRMPASSWORD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCONFIRMPASSWORD.ForeColor = System.Drawing.Color.Silver
        Me.RCONFIRMPASSWORD.Location = New System.Drawing.Point(13, 194)
        Me.RCONFIRMPASSWORD.Margin = New System.Windows.Forms.Padding(4)
        Me.RCONFIRMPASSWORD.Name = "RCONFIRMPASSWORD"
        Me.RCONFIRMPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RCONFIRMPASSWORD.Size = New System.Drawing.Size(616, 25)
        Me.RCONFIRMPASSWORD.TabIndex = 56
        Me.RCONFIRMPASSWORD.Text = "CONFIRM PASSWORD"
        '
        'P2
        '
        Me.P2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P2.BackColor = System.Drawing.Color.White
        Me.P2.Location = New System.Drawing.Point(13, 185)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(616, 2)
        Me.P2.TabIndex = 55
        '
        'P1
        '
        Me.P1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P1.BackColor = System.Drawing.Color.White
        Me.P1.Location = New System.Drawing.Point(13, 144)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(616, 2)
        Me.P1.TabIndex = 54
        '
        'RPASSWORD
        '
        Me.RPASSWORD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RPASSWORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RPASSWORD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPASSWORD.ForeColor = System.Drawing.Color.Silver
        Me.RPASSWORD.Location = New System.Drawing.Point(13, 153)
        Me.RPASSWORD.Margin = New System.Windows.Forms.Padding(4)
        Me.RPASSWORD.Name = "RPASSWORD"
        Me.RPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RPASSWORD.Size = New System.Drawing.Size(616, 25)
        Me.RPASSWORD.TabIndex = 53
        Me.RPASSWORD.Text = "PASSWORD"
        '
        'REmail
        '
        Me.REmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.REmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.REmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.REmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REmail.ForeColor = System.Drawing.Color.Silver
        Me.REmail.Location = New System.Drawing.Point(13, 112)
        Me.REmail.Margin = New System.Windows.Forms.Padding(4)
        Me.REmail.Name = "REmail"
        Me.REmail.Size = New System.Drawing.Size(616, 25)
        Me.REmail.TabIndex = 52
        Me.REmail.Text = "Email"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(13, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 2)
        Me.Panel1.TabIndex = 64
        '
        'RUsername
        '
        Me.RUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RUsername.ForeColor = System.Drawing.Color.Silver
        Me.RUsername.Location = New System.Drawing.Point(13, 70)
        Me.RUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.RUsername.Name = "RUsername"
        Me.RUsername.ReadOnly = True
        Me.RUsername.Size = New System.Drawing.Size(616, 25)
        Me.RUsername.TabIndex = 63
        Me.RUsername.Text = "Username"
        '
        'FRM_Register_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 508)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RUsername)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btc_Register)
        Me.Controls.Add(Me.REmail)
        Me.Controls.Add(Me.RPASSWORD)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.RCONFIRMPASSWORD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Register_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_Register_User"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BarraTitulo As Panel
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents BtnCerrar As Button
    Private WithEvents MeText As Label
    Private WithEvents Key As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents btc_Register As Button
    Friend WithEvents P3 As Panel
    Private WithEvents RCONFIRMPASSWORD As TextBox
    Friend WithEvents P2 As Panel
    Friend WithEvents P1 As Panel
    Private WithEvents RPASSWORD As TextBox
    Private WithEvents REmail As TextBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents RUsername As TextBox
End Class
