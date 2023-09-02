<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PopupFormExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PopupFormExcel))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker_excel = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundRunAdd = New System.ComponentModel.BackgroundWorker()
        Me.BT_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(65, 115)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'BackgroundWorker_excel
        '
        Me.BackgroundWorker_excel.WorkerReportsProgress = True
        Me.BackgroundWorker_excel.WorkerSupportsCancellation = True
        '
        'BackgroundRunAdd
        '
        Me.BackgroundRunAdd.WorkerReportsProgress = True
        Me.BackgroundRunAdd.WorkerSupportsCancellation = True
        '
        'BT_Cancel
        '
        Me.BT_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_Cancel.BackColor = System.Drawing.Color.Red
        Me.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BT_Cancel.ForeColor = System.Drawing.Color.White
        Me.BT_Cancel.Location = New System.Drawing.Point(398, 168)
        Me.BT_Cancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BT_Cancel.Name = "BT_Cancel"
        Me.BT_Cancel.Size = New System.Drawing.Size(91, 25)
        Me.BT_Cancel.TabIndex = 10
        Me.BT_Cancel.Text = "Cancel"
        Me.BT_Cancel.UseVisualStyleBackColor = False
        '
        'FRM_PopupFormExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 272)
        Me.Controls.Add(Me.BT_Cancel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FRM_PopupFormExcel"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PopupForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker_excel As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundRunAdd As System.ComponentModel.BackgroundWorker
    Friend WithEvents BT_Cancel As Button
End Class
