<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Main_SettingSQL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Main_SettingSQL))
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssb_select_sql = New System.Windows.Forms.ToolStripSplitButton()
        Me.MSSqlServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MySQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(700, 49)
        Me.PanelBarraTitulo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(643, 1)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(53, 49)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bot Pampers 2021 V1.1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssb_select_sql})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(700, 26)
        Me.StatusStrip1.TabIndex = 0
        '
        'tssb_select_sql
        '
        Me.tssb_select_sql.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssb_select_sql.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MSSqlServerToolStripMenuItem, Me.MySQLToolStripMenuItem})
        Me.tssb_select_sql.Image = CType(resources.GetObject("tssb_select_sql.Image"), System.Drawing.Image)
        Me.tssb_select_sql.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssb_select_sql.Name = "tssb_select_sql"
        Me.tssb_select_sql.Size = New System.Drawing.Size(39, 24)
        Me.tssb_select_sql.Text = "ToolStripSplitButton1"
        '
        'MSSqlServerToolStripMenuItem
        '
        Me.MSSqlServerToolStripMenuItem.Image = CType(resources.GetObject("MSSqlServerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MSSqlServerToolStripMenuItem.Name = "MSSqlServerToolStripMenuItem"
        Me.MSSqlServerToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.MSSqlServerToolStripMenuItem.Text = "SQLite"
        '
        'MySQLToolStripMenuItem
        '
        Me.MySQLToolStripMenuItem.Image = CType(resources.GetObject("MySQLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MySQLToolStripMenuItem.Name = "MySQLToolStripMenuItem"
        Me.MySQLToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.MySQLToolStripMenuItem.Text = "MySQL"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.StatusStrip1)
        Me.PanelContenedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 49)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(700, 565)
        Me.PanelContenedor.TabIndex = 3
        '
        'FRM_Main_SettingSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 614)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Main_SettingSQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_Main_SettingSQL"
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraTitulo As Panel
    Private WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssb_select_sql As ToolStripSplitButton
    Friend WithEvents MSSqlServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MySQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
End Class
