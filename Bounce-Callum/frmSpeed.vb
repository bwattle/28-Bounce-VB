Public Class frmSpeed
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        frmBounce.XDirection = TrackBar1.Value
        frmBounce.YDirection = TrackBar1.Value

    End Sub
End Class