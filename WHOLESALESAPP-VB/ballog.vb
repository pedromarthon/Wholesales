﻿Imports System.ComponentModel
Imports WHOLESALESAPP_VB.functions
Public Class ballog
    Protected i As Integer = 0

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        itemsmanager.updatelogin()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        i += 1
        If txt_password.Text = getpass("admin") Then
            MAIN.stat = 1
            Me.Hide()

        ElseIf i = 3 Then
            MsgBox("Entered Password 3 times wrong, EXITING!")
            MAIN.stat = 0
            Me.Hide()

        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown

        If e.KeyData = Keys.Enter Then
            btn_login.PerformClick()
        End If

    End Sub

    Private Sub ballog_Closed(sender As Object, e As CancelEventArgs) Handles Me.Closed
        MAIN.stat = 0
    End Sub
End Class