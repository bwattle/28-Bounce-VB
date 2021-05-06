Public Class frmBounce
    Dim g As Graphics       'create a graphics opject to display 
    Dim shpStage As New Rectangle(0, 0, 640, 480)  'stage rectangle position & dimensions
    Dim shpBall As New Rectangle(50, 20, 90, 90)   'ball pos'n & dimensions - in 'RepaintBounce', we call the "FillElipse" class to create the circle
    Dim myBallBrush As Brush
    Dim myBGBrush As Brush
    Dim speed As Int16
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

    Private Sub FrmBounce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shpBallFill_R = 10      'set default ball RGB colours of your own choice
        shpBallFill_G = 100
        shpBallFill_B = 200
        shpBGFill_R = 250      'set default stage RGB colours of your own choice
        shpBGFill_G = 150
        shpBGFill_B = 50
        Timer1.Enabled = True   'start the timer
    End Sub

    Private Sub FrmBounce_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'if this code was under "load" it would be wiped as the form "shows". 
        'See https://docs.microsoft.com/en-us/dotnet/framework/winforms/order-of-events-in-windows-forms
        RepaintBounce()
    End Sub

    Public Sub RepaintBounce()
        'this PUBLIC sub can be called by the colour subform to repaint the new colours
        g = panelMain.CreateGraphics         'g for graphics
        myBGBrush = New SolidBrush(Color.FromArgb(shpBGFill_R, shpBGFill_G, shpBGFill_B))
        g.FillRectangle(myBGBrush, shpStage) 'paint the stage
        myBallBrush = New SolidBrush(Color.FromArgb(shpBallFill_R, shpBallFill_G, shpBallFill_B))
        g.FillEllipse(myBallBrush, shpBall)  'paint the ball
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoveBall() 'run the "MoveBall" function on each tick of the clock
        'used https://www.wikihow.com/Add-a-Timer-in-Visual-Basic
    End Sub

    Private Sub MoveBall()
        'Bounce shpBall around frmBounce
        'Requires Speed, XDirection, YDirection at form level
        Dim Xpos As Int16
        Dim Ypos As Int16
        Dim XDirection As Int16
        Dim YDirection As Int16

        'hard code speed for testing
        speed = 10
        XDirection = 1
        YDirection = 1

        'Get current ball position
        Xpos = shpBall.Left ' X changed to Xpos because in this version of VB, 
        Ypos = shpBall.Top  '   "X" & "Y" are used to SET position

        'The ball has reached the RHS of screen
        'Move back to edge and reverse X direction
        If Xpos > Me.Width - shpBall.Width Then
            Xpos = Me.Width - shpBall.Width
            XDirection *= -1
        End If

        'The ball has reached the LHS of screen
        'Move back to edge and reverse X direction
        If Xpos < 0 Then
            Xpos = 0
            XDirection *= -1
        End If

        'The ball has reached the bottom of screen
        'Move back to edge and reverse y direction
        If Ypos > Me.Height - shpBall.Width Then
            Ypos = Me.Height - shpBall.Width
            YDirection *= -1
        End If

        'The ball has reached the top of screen
        'Move back to edge and reverse Y direction
        If Ypos < 0 Then
            Ypos = 0
            YDirection *= -1
        End If

        'Increment or decrement X and Y values
        Xpos += (XDirection * speed)
        Ypos += (YDirection * speed)

        'Actually move the ball
        shpBall.X = Xpos
        shpBall.Y = Ypos
        RepaintBounce()
    End Sub
End Class
