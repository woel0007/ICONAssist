<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthForm
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
        Me.btnServerConnect = New System.Windows.Forms.Button()
        Me.txtConnectStatus = New System.Windows.Forms.TextBox()
        Me.lblAuthPhone = New System.Windows.Forms.Label()
        Me.txtAuthPhone = New System.Windows.Forms.TextBox()
        Me.txtAuthUser = New System.Windows.Forms.TextBox()
        Me.lblAuthUser = New System.Windows.Forms.Label()
        Me.txtAuthPass = New System.Windows.Forms.TextBox()
        Me.lblAuthPass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnServerConnect
        '
        Me.btnServerConnect.Location = New System.Drawing.Point(86, 113)
        Me.btnServerConnect.Name = "btnServerConnect"
        Me.btnServerConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnServerConnect.TabIndex = 0
        Me.btnServerConnect.Text = "Connect"
        Me.btnServerConnect.UseVisualStyleBackColor = True
        '
        'txtConnectStatus
        '
        Me.txtConnectStatus.Location = New System.Drawing.Point(172, 116)
        Me.txtConnectStatus.Name = "txtConnectStatus"
        Me.txtConnectStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtConnectStatus.TabIndex = 1
        Me.txtConnectStatus.Text = "Not Connected"
        '
        'lblAuthPhone
        '
        Me.lblAuthPhone.AutoSize = True
        Me.lblAuthPhone.Location = New System.Drawing.Point(21, 18)
        Me.lblAuthPhone.Name = "lblAuthPhone"
        Me.lblAuthPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblAuthPhone.TabIndex = 2
        Me.lblAuthPhone.Text = "Phone"
        '
        'txtAuthPhone
        '
        Me.txtAuthPhone.Location = New System.Drawing.Point(76, 15)
        Me.txtAuthPhone.Name = "txtAuthPhone"
        Me.txtAuthPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthPhone.TabIndex = 3
        Me.txtAuthPhone.Text = "7632955315"
        '
        'txtAuthUser
        '
        Me.txtAuthUser.Location = New System.Drawing.Point(76, 47)
        Me.txtAuthUser.Name = "txtAuthUser"
        Me.txtAuthUser.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthUser.TabIndex = 5
        Me.txtAuthUser.Text = "jwoelfel"
        '
        'lblAuthUser
        '
        Me.lblAuthUser.AutoSize = True
        Me.lblAuthUser.Location = New System.Drawing.Point(19, 50)
        Me.lblAuthUser.Name = "lblAuthUser"
        Me.lblAuthUser.Size = New System.Drawing.Size(55, 13)
        Me.lblAuthUser.TabIndex = 4
        Me.lblAuthUser.Text = "Username"
        '
        'txtAuthPass
        '
        Me.txtAuthPass.Location = New System.Drawing.Point(76, 81)
        Me.txtAuthPass.Name = "txtAuthPass"
        Me.txtAuthPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAuthPass.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthPass.TabIndex = 7
        Me.txtAuthPass.Text = "2cool4me"
        '
        'lblAuthPass
        '
        Me.lblAuthPass.AutoSize = True
        Me.lblAuthPass.Location = New System.Drawing.Point(21, 84)
        Me.lblAuthPass.Name = "lblAuthPass"
        Me.lblAuthPass.Size = New System.Drawing.Size(53, 13)
        Me.lblAuthPass.TabIndex = 6
        Me.lblAuthPass.Text = "Password"
        '
        'AuthForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 167)
        Me.Controls.Add(Me.txtAuthPass)
        Me.Controls.Add(Me.lblAuthPass)
        Me.Controls.Add(Me.txtAuthUser)
        Me.Controls.Add(Me.lblAuthUser)
        Me.Controls.Add(Me.txtAuthPhone)
        Me.Controls.Add(Me.lblAuthPhone)
        Me.Controls.Add(Me.txtConnectStatus)
        Me.Controls.Add(Me.btnServerConnect)
        Me.Name = "AuthForm"
        Me.Text = "Login to ICON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnServerConnect As System.Windows.Forms.Button
    Friend WithEvents txtConnectStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthPhone As System.Windows.Forms.Label
    Friend WithEvents txtAuthPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthUser As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthUser As System.Windows.Forms.Label
    Friend WithEvents txtAuthPass As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthPass As System.Windows.Forms.Label
End Class
