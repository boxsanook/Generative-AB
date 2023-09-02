﻿Imports System.Runtime.InteropServices

Public Class FRM_Main_SettingSQL

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        End If

    End Sub
    Private Sub PanelBarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseDown
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        End If
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()

        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub
    Private currentForm As Form = Nothing
    Private Sub AbrirFormEnPanel(childForm As Form)

        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(childForm)
        PanelContenedor.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub FRM_Main_SettingSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModuleSQLconfig.SQLSetting = "SQLite" Then
            AbrirFormEnPanel(New FRM_SettingSQLite)
            ModuleSQLconfig.SQLSetting = "SQLite"
        ElseIf ModuleSQLconfig.SQLSetting = "MySQL" Then
            AbrirFormEnPanel(New FRM_SettingMySQL)
            ModuleSQLconfig.SQLSetting = "MySQL"
        End If


    End Sub

    Private Sub MySQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySQLToolStripMenuItem.Click
        AbrirFormEnPanel(New FRM_SettingMySQL)
        ModuleSQLconfig.SQLSetting = "MySQL"
    End Sub

    Private Sub MSSqlServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MSSqlServerToolStripMenuItem.Click
        AbrirFormEnPanel(New FRM_SettingSQLite)
        ModuleSQLconfig.SQLSetting = "SQLite"
    End Sub

End Class