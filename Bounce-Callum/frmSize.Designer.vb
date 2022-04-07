<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSize
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Size1Input = New System.Windows.Forms.TextBox()
        Me.Size2Input = New System.Windows.Forms.TextBox()
        Me.SetSize = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Size1Input
        '
        Me.Size1Input.Location = New System.Drawing.Point(12, 55)
        Me.Size1Input.Name = "Size1Input"
        Me.Size1Input.Size = New System.Drawing.Size(100, 20)
        Me.Size1Input.TabIndex = 0
        '
        'Size2Input
        '
        Me.Size2Input.Location = New System.Drawing.Point(130, 55)
        Me.Size2Input.Name = "Size2Input"
        Me.Size2Input.Size = New System.Drawing.Size(100, 20)
        Me.Size2Input.TabIndex = 1
        '
        'SetSize
        '
        Me.SetSize.Location = New System.Drawing.Point(155, 90)
        Me.SetSize.Name = "SetSize"
        Me.SetSize.Size = New System.Drawing.Size(75, 23)
        Me.SetSize.TabIndex = 2
        Me.SetSize.Text = "Set Size"
        Me.SetSize.UseVisualStyleBackColor = True
        '
        'frmSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 204)
        Me.Controls.Add(Me.SetSize)
        Me.Controls.Add(Me.Size2Input)
        Me.Controls.Add(Me.Size1Input)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSize"
        Me.Text = "Size"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Size1Input As TextBox
    Friend WithEvents Size2Input As TextBox
    Friend WithEvents SetSize As Button
End Class
