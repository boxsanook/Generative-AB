<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Register))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MeText = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.ProductCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Cliente_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ExpiryDate = New System.Windows.Forms.TextBox()
        Me.txt_uKey = New System.Windows.Forms.TextBox()
        Me.txt_sKey = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RegisterKey = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Update_Register = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.token = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.PictureBox1)
        Me.BarraTitulo.Controls.Add(Me.MeText)
        Me.BarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(669, 47)
        Me.BarraTitulo.TabIndex = 16
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
        'MeText
        '
        Me.MeText.AutoSize = True
        Me.MeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeText.ForeColor = System.Drawing.Color.White
        Me.MeText.Location = New System.Drawing.Point(69, 14)
        Me.MeText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MeText.Name = "MeText"
        Me.MeText.Size = New System.Drawing.Size(220, 20)
        Me.MeText.TabIndex = 15
        Me.MeText.Text = " Cliente Registry Application"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrar.Location = New System.Drawing.Point(620, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(51, 47)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'ProductCode
        '
        Me.ProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCode.Location = New System.Drawing.Point(152, 55)
        Me.ProductCode.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = True
        Me.ProductCode.Size = New System.Drawing.Size(477, 26)
        Me.ProductCode.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Product Code :"
        '
        'txt_Cliente_ID
        '
        Me.txt_Cliente_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cliente_ID.Location = New System.Drawing.Point(152, 89)
        Me.txt_Cliente_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Cliente_ID.Name = "txt_Cliente_ID"
        Me.txt_Cliente_ID.ReadOnly = True
        Me.txt_Cliente_ID.Size = New System.Drawing.Size(477, 26)
        Me.txt_Cliente_ID.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Cliente ID :"
        '
        'ExpiryDate
        '
        Me.ExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDate.Location = New System.Drawing.Point(131, 0)
        Me.ExpiryDate.Margin = New System.Windows.Forms.Padding(4)
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.ReadOnly = True
        Me.ExpiryDate.Size = New System.Drawing.Size(201, 26)
        Me.ExpiryDate.TabIndex = 87
        '
        'txt_uKey
        '
        Me.txt_uKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uKey.Location = New System.Drawing.Point(152, 157)
        Me.txt_uKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_uKey.Name = "txt_uKey"
        Me.txt_uKey.ReadOnly = True
        Me.txt_uKey.Size = New System.Drawing.Size(477, 26)
        Me.txt_uKey.TabIndex = 84
        '
        'txt_sKey
        '
        Me.txt_sKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sKey.Location = New System.Drawing.Point(152, 123)
        Me.txt_sKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sKey.Name = "txt_sKey"
        Me.txt_sKey.ReadOnly = True
        Me.txt_sKey.Size = New System.Drawing.Size(477, 26)
        Me.txt_sKey.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Expiry Date :  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "uKey :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(82, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "sKey :"
        '
        'RegisterKey
        '
        Me.RegisterKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterKey.Location = New System.Drawing.Point(154, 225)
        Me.RegisterKey.Margin = New System.Windows.Forms.Padding(4)
        Me.RegisterKey.Multiline = True
        Me.RegisterKey.Name = "RegisterKey"
        Me.RegisterKey.Size = New System.Drawing.Size(477, 122)
        Me.RegisterKey.TabIndex = 89
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(21, 0)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(123, 20)
        Me.label2.TabIndex = 90
        Me.label2.Text = "Product Key :"
        '
        'Update_Register
        '
        Me.Update_Register.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Update_Register.FlatAppearance.BorderSize = 0
        Me.Update_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Update_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Register.ForeColor = System.Drawing.Color.White
        Me.Update_Register.Location = New System.Drawing.Point(152, 385)
        Me.Update_Register.Margin = New System.Windows.Forms.Padding(4)
        Me.Update_Register.Name = "Update_Register"
        Me.Update_Register.Size = New System.Drawing.Size(165, 43)
        Me.Update_Register.TabIndex = 91
        Me.Update_Register.Text = "Update Register"
        Me.Update_Register.UseVisualStyleBackColor = False
        Me.Update_Register.Visible = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Green
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(496, 385)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(133, 43)
        Me.btnRegister.TabIndex = 92
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(1, 57)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 25)
        Me.Panel1.TabIndex = 93
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(1, 90)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(144, 25)
        Me.Panel2.TabIndex = 94
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(1, 124)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(144, 25)
        Me.Panel3.TabIndex = 95
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(0, 157)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(144, 25)
        Me.Panel4.TabIndex = 95
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ExpiryDate)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(44, 190)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(332, 25)
        Me.Panel5.TabIndex = 95
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.label2)
        Me.Panel6.Location = New System.Drawing.Point(1, 225)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(144, 25)
        Me.Panel6.TabIndex = 96
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.token)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Location = New System.Drawing.Point(406, 190)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(223, 25)
        Me.Panel7.TabIndex = 97
        '
        'token
        '
        Me.token.Dock = System.Windows.Forms.DockStyle.Fill
        Me.token.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.token.Location = New System.Drawing.Point(71, 0)
        Me.token.Margin = New System.Windows.Forms.Padding(4)
        Me.token.Name = "token"
        Me.token.ReadOnly = True
        Me.token.Size = New System.Drawing.Size(152, 26)
        Me.token.TabIndex = 89
        Me.token.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Token :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(369, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 54)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRM_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(669, 441)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Update_Register)
        Me.Controls.Add(Me.RegisterKey)
        Me.Controls.Add(Me.txt_uKey)
        Me.Controls.Add(Me.txt_sKey)
        Me.Controls.Add(Me.txt_Cliente_ID)
        Me.Controls.Add(Me.ProductCode)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FRM_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_Register"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BarraTitulo As Panel
    Private WithEvents PictureBox1 As PictureBox
    Public WithEvents MeText As Label
    Private WithEvents BtnCerrar As Button
    Public WithEvents ProductCode As TextBox
    Private WithEvents Label6 As Label
    Public WithEvents txt_Cliente_ID As TextBox
    Private WithEvents Label7 As Label
    Public WithEvents ExpiryDate As TextBox
    Public WithEvents txt_uKey As TextBox
    Public WithEvents txt_sKey As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Public WithEvents RegisterKey As TextBox
    Private WithEvents label2 As Label
    Private WithEvents Update_Register As Button
    Private WithEvents btnRegister As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Public WithEvents token As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
