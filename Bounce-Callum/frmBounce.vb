Public Class frmBounce
    Dim g As Graphics
    Public Size1 As Int32 = 90
    Public Size2 As Int32 = 90
    Dim r As New Rectangle(0, 0, Size1, Size2)  'rectangle position & dimensions
    Public shpBall As New Rectangle(50, 50, Size1, Size2)  'circle position & dimensions
    Dim myBallBrush As Brush
    Dim myBGBrush As Brush
    Public shpBallFill_R As Integer     'global colours
    Public shpBallFill_G As Integer
    Public shpBallFill_B As Integer
    Public shpBGFill_R As Integer
    Public shpBGFill_G As Integer
    Public shpBGFill_B As Integer
    Public Speed As Int16 = 1
    Dim Xpos As Int16
    Dim Ypos As Int16
    Public YDirection As Int16 = 1
    Public XDirection As Int16 = 1
    Dim RCB As Random = New Random
    Public ClickAmount As Int16 = 0



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
        ScoreAmount.Text = ClickAmount
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
        g.FillEllipse(myBallBrush, shpBall)
    End Sub

    Private Sub moveBall()


        'Speed = 1

        Xpos = shpBall.Left
        shpBall.Y = shpBall.Top

        'If shpBall.X > panelMain.Width - shpBall.Width Then
        'shpBall.X = panelMain.Width - shpBall.Width
        'XDirection = XDirection * -1
        'End If

        If shpBall.X > panelMain.Width - shpBall.Width Then
            shpBall.X = panelMain.Width - shpBall.Width
            XDirection = XDirection * -1
        End If

        If shpBall.X < 0 Then
            shpBall.X = 0
            XDirection = XDirection * -1
        End If

        If shpBall.Y > panelMain.Height - shpBall.Width Then
            shpBall.Y = panelMain.Height - shpBall.Width
            YDirection = YDirection * -1
        End If

        If shpBall.Y < 0 Then
            shpBall.Y = 0
            YDirection = YDirection * -1
        End If



        Xpos = shpBall.X + (XDirection * Speed)
        Ypos = shpBall.Y + (YDirection * Speed)
        shpBall.X = Xpos
        shpBall.Y = Ypos
        repaintBounce()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        moveBall()
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub StartBounce_Click(sender As Object, e As EventArgs) Handles StartBounce.Click
        Timer1.Enabled = True
    End Sub

    Private Sub panelMain_MouseDown(sender As Object, e As MouseEventArgs) Handles panelMain.MouseDown
        Dim b As Rectangle = shpBall
        If e.X > b.X And e.X < b.X + b.Width And e.Y > b.Y And e.Y < b.Y + b.Height Then
            If Timer1.Enabled = True Then
                shpBallFill_R = RCB.Next(0, 255)
                shpBallFill_G = RCB.Next(0, 255)
                shpBallFill_B = RCB.Next(0, 255)
                shpBGFill_R = RCB.Next(0, 255)
                shpBGFill_G = RCB.Next(0, 255)
                shpBGFill_B = RCB.Next(0, 255)
                ClickAmount = ClickAmount + 1
                ScoreAmount.Text = ClickAmount
            Else
                MsgBox("Nice Try")
            End If
        Else
            ClickAmount = 0
                ScoreAmount.Text = ClickAmount
            End If

    End Sub

    Private Sub StopBounce_Click(sender As Object, e As EventArgs) Handles StopBounce.Click
        Timer1.Enabled = False
    End Sub
End Class
