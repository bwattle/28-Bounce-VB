Imports System.Drawing.Drawing2D
Public Class frmColour
    Dim g As Graphics
    Dim r As New Rectangle(0, 0, 130, 130)  'location of rectangle
    Dim c As New Rectangle(20, 20, 90, 90)  'location of circle
    Dim myBGBrush As Brush                  'brush fill colours for BG
    Dim myBallBrush As Brush                'brush fill colours for rectangle
    Dim colourBallFill_R As Integer 'local colours
    Dim colourBallFill_G As Integer
    Dim colourBallFill_B As Integer
    Dim colourBGFill_R As Integer
    Dim colourBGFill_G As Integer
    Dim colourBGFill_B As Integer

    Private Sub frmColour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colourBallFill_R = frmBounce.shpBallFill_R  'inerit the existing ball colours
        colourBallFill_G = frmBounce.shpBallFill_G
        colourBallFill_B = frmBounce.shpBallFill_B
        colourBGFill_R = frmBounce.shpBGFill_R      'inerit the existing BG colours
        colourBGFill_G = frmBounce.shpBGFill_G
        colourBGFill_B = frmBounce.shpBGFill_B
        tbrRed.Value = colourBallFill_R             'set the trackbars to the current BALL colours
        tbrGreen.Value = colourBallFill_G
        tbrBlue.Value = colourBallFill_B
    End Sub

    Private Sub frmColour_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        g = Panel1.CreateGraphics               'g for graphics
        myBGBrush = New SolidBrush(Color.FromArgb(colourBGFill_R, colourBGFill_G, colourBGFill_B))
        g.FillRectangle(myBGBrush, r)
        myBallBrush = New SolidBrush(Color.FromArgb(tbrRed.Value, tbrGreen.Value, tbrBlue.Value))
        g.FillEllipse(myBallBrush, c)
    End Sub

    Private Sub colourChange(sender As Object, e As EventArgs) Handles tbrRed.Scroll, tbrGreen.Scroll, tbrBlue.Scroll
        If optBall.Checked Then
            colourBallFill_R = tbrRed.Value  'update to new ball colours
            colourBallFill_G = tbrGreen.Value
            colourBallFill_B = tbrBlue.Value
            myBallBrush = New SolidBrush(Color.FromArgb(colourBallFill_R, colourBallFill_G, colourBallFill_B))
            g.FillEllipse(myBallBrush, c)
        Else
            colourBGFill_R = tbrRed.Value      'update to new BG colours
            colourBGFill_G = tbrGreen.Value
            colourBGFill_B = tbrBlue.Value
            myBGBrush = New SolidBrush(Color.FromArgb(colourBGFill_R, colourBGFill_G, colourBGFill_B))
            g.FillRectangle(myBGBrush, r)       'paint rectangle fill - this will cover circle
            myBallBrush = New SolidBrush(Color.FromArgb(colourBallFill_R, colourBallFill_G, colourBallFill_B))
            g.FillEllipse(myBallBrush, c)      'paint circle fill again to put it on top
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmBounce.shpBallFill_R = colourBallFill_R  'update the globals based on the trackbar settings
        frmBounce.shpBallFill_G = colourBallFill_G
        frmBounce.shpBallFill_B = colourBallFill_B
        frmBounce.shpBGFill_R = colourBGFill_R
        frmBounce.shpBGFill_G = colourBGFill_G
        frmBounce.shpBGFill_B = colourBGFill_B
        frmBounce.repaintBounce()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'msgbox was for testing
        'MsgBox("Ball colour " & colourBallFill_R & ", " & colourBallFill_G & ", " & colourBallFill_B & "; BG colour " & colourBGFill_R & ", " & colourBGFill_G & ", " & colourBGFill_B)
        frmBounce.repaintBounce()
        Me.Close()
    End Sub

    Private Sub optBall_CheckedChanged(sender As Object, e As EventArgs) Handles optBall.CheckedChanged
        If optBall.Checked Then
            tbrRed.Value = colourBallFill_R
            tbrGreen.Value = colourBallFill_G
            tbrBlue.Value = colourBallFill_B
        Else
            tbrRed.Value = colourBGFill_R
            tbrGreen.Value = colourBGFill_G
            tbrBlue.Value = colourBGFill_B
        End If
    End Sub
End Class