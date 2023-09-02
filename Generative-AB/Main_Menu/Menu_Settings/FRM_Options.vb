Public Class FRM_Options
    Private Sub MeClose_Click(sender As Object, e As EventArgs) Handles MeClose.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txt_lineNotify.Enabled = CheckBox1.Checked
    End Sub
End Class