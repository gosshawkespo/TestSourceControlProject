<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.txtOutput1 = New System.Windows.Forms.TextBox()
        Me.txtOutput2 = New System.Windows.Forms.TextBox()
        Me.btnTest2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClickMe
        '
        Me.btnClickMe.Location = New System.Drawing.Point(86, 37)
        Me.btnClickMe.Name = "btnClickMe"
        Me.btnClickMe.Size = New System.Drawing.Size(75, 23)
        Me.btnClickMe.TabIndex = 0
        Me.btnClickMe.Text = "Test1"
        Me.btnClickMe.UseVisualStyleBackColor = True
        '
        'txtOutput1
        '
        Me.txtOutput1.Location = New System.Drawing.Point(86, 111)
        Me.txtOutput1.Name = "txtOutput1"
        Me.txtOutput1.Size = New System.Drawing.Size(173, 20)
        Me.txtOutput1.TabIndex = 1
        '
        'txtOutput2
        '
        Me.txtOutput2.Location = New System.Drawing.Point(86, 137)
        Me.txtOutput2.Name = "txtOutput2"
        Me.txtOutput2.Size = New System.Drawing.Size(173, 20)
        Me.txtOutput2.TabIndex = 2
        '
        'btnTest2
        '
        Me.btnTest2.Location = New System.Drawing.Point(184, 37)
        Me.btnTest2.Name = "btnTest2"
        Me.btnTest2.Size = New System.Drawing.Size(75, 23)
        Me.btnTest2.TabIndex = 3
        Me.btnTest2.Text = "Test2"
        Me.btnTest2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 261)
        Me.Controls.Add(Me.btnTest2)
        Me.Controls.Add(Me.txtOutput2)
        Me.Controls.Add(Me.txtOutput1)
        Me.Controls.Add(Me.btnClickMe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickMe As Button
    Friend WithEvents txtOutput1 As TextBox
    Friend WithEvents txtOutput2 As TextBox
    Friend WithEvents btnTest2 As Button
End Class
