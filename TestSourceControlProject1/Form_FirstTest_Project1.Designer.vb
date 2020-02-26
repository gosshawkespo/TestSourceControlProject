<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstTest
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
        Me.btnTest3 = New System.Windows.Forms.Button()
        Me.txtOutput3 = New System.Windows.Forms.TextBox()
        Me.btnTest4 = New System.Windows.Forms.Button()
        Me.txtOutput4 = New System.Windows.Forms.TextBox()
        Me.btnTest5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
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
        'btnTest3
        '
        Me.btnTest3.Location = New System.Drawing.Point(291, 37)
        Me.btnTest3.Name = "btnTest3"
        Me.btnTest3.Size = New System.Drawing.Size(75, 23)
        Me.btnTest3.TabIndex = 4
        Me.btnTest3.Text = "Test3"
        Me.btnTest3.UseVisualStyleBackColor = True
        '
        'txtOutput3
        '
        Me.txtOutput3.Location = New System.Drawing.Point(86, 163)
        Me.txtOutput3.Name = "txtOutput3"
        Me.txtOutput3.Size = New System.Drawing.Size(173, 20)
        Me.txtOutput3.TabIndex = 5
        '
        'btnTest4
        '
        Me.btnTest4.Location = New System.Drawing.Point(401, 37)
        Me.btnTest4.Name = "btnTest4"
        Me.btnTest4.Size = New System.Drawing.Size(75, 23)
        Me.btnTest4.TabIndex = 6
        Me.btnTest4.Text = "Test4"
        Me.btnTest4.UseVisualStyleBackColor = True
        '
        'txtOutput4
        '
        Me.txtOutput4.Location = New System.Drawing.Point(86, 191)
        Me.txtOutput4.Name = "txtOutput4"
        Me.txtOutput4.Size = New System.Drawing.Size(173, 20)
        Me.txtOutput4.TabIndex = 7
        '
        'btnTest5
        '
        Me.btnTest5.Location = New System.Drawing.Point(401, 78)
        Me.btnTest5.Name = "btnTest5"
        Me.btnTest5.Size = New System.Drawing.Size(75, 23)
        Me.btnTest5.TabIndex = 8
        Me.btnTest5.Text = "Test5_me"
        Me.btnTest5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(539, 78)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 23)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "Test6_me"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'frmFirstTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 261)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btnTest5)
        Me.Controls.Add(Me.txtOutput4)
        Me.Controls.Add(Me.btnTest4)
        Me.Controls.Add(Me.txtOutput3)
        Me.Controls.Add(Me.btnTest3)
        Me.Controls.Add(Me.btnTest2)
        Me.Controls.Add(Me.txtOutput2)
        Me.Controls.Add(Me.txtOutput1)
        Me.Controls.Add(Me.btnClickMe)
        Me.Name = "frmFirstTest"
        Me.Text = "First Test - Project 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickMe As Button
    Friend WithEvents txtOutput1 As TextBox
    Friend WithEvents txtOutput2 As TextBox
    Friend WithEvents btnTest2 As Button
    Friend WithEvents btnTest3 As Button
    Friend WithEvents txtOutput3 As TextBox
    Friend WithEvents btnTest4 As Button
    Friend WithEvents txtOutput4 As TextBox
    Friend WithEvents btnTest5 As Button
    Friend WithEvents btn6 As Button
End Class
