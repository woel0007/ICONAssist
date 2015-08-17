<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
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
        Me.btnGetMembers = New System.Windows.Forms.Button()
        Me.btnContributionReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetMembers
        '
        Me.btnGetMembers.Location = New System.Drawing.Point(13, 13)
        Me.btnGetMembers.Name = "btnGetMembers"
        Me.btnGetMembers.Size = New System.Drawing.Size(170, 23)
        Me.btnGetMembers.TabIndex = 0
        Me.btnGetMembers.Text = "Get Members" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnGetMembers.UseVisualStyleBackColor = True
        '
        'btnContributionReport
        '
        Me.btnContributionReport.Location = New System.Drawing.Point(13, 42)
        Me.btnContributionReport.Name = "btnContributionReport"
        Me.btnContributionReport.Size = New System.Drawing.Size(170, 23)
        Me.btnContributionReport.TabIndex = 1
        Me.btnContributionReport.Text = "Generate Contribution Report"
        Me.btnContributionReport.UseVisualStyleBackColor = True
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 263)
        Me.Controls.Add(Me.btnContributionReport)
        Me.Controls.Add(Me.btnGetMembers)
        Me.Name = "ControlPanel"
        Me.Text = "Control Panel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetMembers As System.Windows.Forms.Button
    Friend WithEvents btnContributionReport As System.Windows.Forms.Button
End Class
