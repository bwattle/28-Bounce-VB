Public Class frmSpeed
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim xsign, ysign As Integer
        xsign = Math.Sign(frmBounce.directionX) Or 1
        ysign = Math.Sign(frmBounce.directionY) Or 1
        frmBounce.directionX = TrackBar1.Value * xsign
        frmBounce.directionY = TrackBar1.Value * ysign
    End Sub
End Class