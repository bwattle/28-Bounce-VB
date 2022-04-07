Imports System.Text.RegularExpressions

Public Class frmSize
    Private Sub frmSize_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Radius_TextChanged(sender As Object, e As EventArgs) Handles Radius.TextChanged
        If Not (Regex.IsMatch(Radius.Text, "\D") Or Radius.Text = "") Then
            frmBounce.c.Width = CInt(Radius.Text) * 2
            frmBounce.c.Height = CInt(Radius.Text) * 2
        End If
    End Sub
End Class