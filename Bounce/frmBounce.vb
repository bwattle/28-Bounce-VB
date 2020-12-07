Public Class frmBounce
    Dim g As Graphics
    Dim r As New Rectangle(0, 0, 640, 480)  'rectangle position & dimensions
    Dim c As New Rectangle(50, 20, 90, 90)  'circle position & dimensions
    Dim myBallBrush As Brush
    Dim myBGBrush As Brush
    Public shpBallFill_R As Integer     'global colours
    Public shpBallFill_G As Integer
    Public shpBallFill_B As Integer
    Public shpBGFill_R As Integer
    Public shpBGFill_G As Integer
    Public shpBGFill_B As Integer

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        frmColour.Show()
    End Sub

    Private Sub SpeedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeedToolStripMenuItem.Click
        frmSpeed.Show()
    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
        frmSize.Show()
    End Sub

    Private Sub frmBounce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shpBallFill_R = 10      'set default colours of your own choice
        shpBallFill_G = 100
        shpBallFill_B = 200
        shpBGFill_R = 250
        shpBGFill_G = 150
        shpBGFill_B = 50
    End Sub

    Private Sub frmBounce_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'if this code was under "load" it would be wiped as the form "shows". 
        'See https: //docs.microsoft.com/en-us/dotnet/framework/winforms/order-of-events-in-windows-forms
        repaintBounce()
    End Sub

    Public Sub repaintBounce()
        'this PUBLIC sub can be called by the colour subform to repaint the new colours
        g = panelMain.CreateGraphics               'g for graphics
        myBGBrush = New SolidBrush(Color.FromArgb(shpBGFill_R, shpBGFill_G, shpBGFill_B))
        g.FillRectangle(myBGBrush, r)
        myBallBrush = New SolidBrush(Color.FromArgb(shpBallFill_R, shpBallFill_G, shpBallFill_B))
        g.FillEllipse(myBallBrush, c)
    End Sub
End Class
