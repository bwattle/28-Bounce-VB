Public Class frmSize
    Private Sub frmSize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size1Input.Text = frmBounce.Size1
        Size2Input.Text = frmBounce.Size2
    End Sub



    Private Sub SetSize_Click(sender As Object, e As EventArgs) Handles SetSize.Click
        frmBounce.Size1 = Size1Input.Text
        frmBounce.Size2 = Size2Input.Text
        frmBounce.shpBall.Width = frmBounce.Size1
        frmBounce.shpBall.Height = frmBounce.Size2
        Close()
    End Sub
End Class