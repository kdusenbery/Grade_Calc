<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnForums = New System.Windows.Forms.Button()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblForums = New System.Windows.Forms.Label()
        Me.lblAssign = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(332, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 31)
        Me.lblName.TabIndex = 0
        '
        'btnForums
        '
        Me.btnForums.Location = New System.Drawing.Point(152, 221)
        Me.btnForums.Name = "btnForums"
        Me.btnForums.Size = New System.Drawing.Size(75, 23)
        Me.btnForums.TabIndex = 1
        Me.btnForums.Text = "Next"
        Me.btnForums.UseVisualStyleBackColor = True
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(338, 221)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.Text = "Next"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'btnFinal
        '
        Me.btnFinal.Location = New System.Drawing.Point(551, 221)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(75, 23)
        Me.btnFinal.TabIndex = 3
        Me.btnFinal.Text = "Next"
        Me.btnFinal.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(338, 372)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblForums
        '
        Me.lblForums.AutoSize = True
        Me.lblForums.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForums.Location = New System.Drawing.Point(152, 171)
        Me.lblForums.Name = "lblForums"
        Me.lblForums.Size = New System.Drawing.Size(75, 24)
        Me.lblForums.TabIndex = 5
        Me.lblForums.Text = "Forums"
        '
        'lblAssign
        '
        Me.lblAssign.AutoSize = True
        Me.lblAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssign.Location = New System.Drawing.Point(324, 171)
        Me.lblAssign.Name = "lblAssign"
        Me.lblAssign.Size = New System.Drawing.Size(118, 24)
        Me.lblAssign.TabIndex = 6
        Me.lblAssign.Text = "Assignments"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(535, 171)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(114, 24)
        Me.lblFinal.TabIndex = 7
        Me.lblFinal.Text = "Final Project"
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(770, 448)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblAssign)
        Me.Controls.Add(Me.lblForums)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnFinal)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.btnForums)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents btnForums As Button
    Friend WithEvents btnAssign As Button
    Friend WithEvents btnFinal As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblForums As Label
    Friend WithEvents lblAssign As Label
    Friend WithEvents lblFinal As Label
End Class
