﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnTest1_Proj2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTest1_Proj2
        '
        Me.btnTest1_Proj2.Location = New System.Drawing.Point(188, 67)
        Me.btnTest1_Proj2.Name = "btnTest1_Proj2"
        Me.btnTest1_Proj2.Size = New System.Drawing.Size(183, 49)
        Me.btnTest1_Proj2.TabIndex = 0
        Me.btnTest1_Proj2.Text = "TEST1 Proj 2"
        Me.btnTest1_Proj2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 261)
        Me.Controls.Add(Me.btnTest1_Proj2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTest1_Proj2 As Button
End Class