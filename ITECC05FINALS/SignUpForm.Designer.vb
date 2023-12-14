<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        signUp = New Button()
        SignUpLabel = New Label()
        SignPassword = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        SignUsername = New TextBox()
        ConfPass = New TextBox()
        Label1 = New Label()
        cancel = New Button()
        SuspendLayout()
        ' 
        ' signUp
        ' 
        signUp.Font = New Font("Bantayog", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        signUp.Location = New Point(442, 330)
        signUp.Name = "signUp"
        signUp.Size = New Size(94, 23)
        signUp.TabIndex = 0
        signUp.Text = "Sign-Up"
        signUp.UseVisualStyleBackColor = True
        ' 
        ' SignUpLabel
        ' 
        SignUpLabel.AutoSize = True
        SignUpLabel.Font = New Font("Bukhari Script Alternates", 29.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignUpLabel.Location = New Point(301, 38)
        SignUpLabel.Name = "SignUpLabel"
        SignUpLabel.Size = New Size(173, 56)
        SignUpLabel.TabIndex = 2
        SignUpLabel.Text = "Sign Up"
        ' 
        ' SignPassword
        ' 
        SignPassword.Location = New Point(243, 215)
        SignPassword.Name = "SignPassword"
        SignPassword.PasswordChar = "*"c
        SignPassword.Size = New Size(293, 23)
        SignPassword.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bantayog", 9F)
        Label3.Location = New Point(243, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 12)
        Label3.TabIndex = 7
        Label3.Text = "Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bantayog", 9F)
        Label2.Location = New Point(243, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 12)
        Label2.TabIndex = 6
        Label2.Text = "Username:"
        ' 
        ' SignUsername
        ' 
        SignUsername.Location = New Point(243, 147)
        SignUsername.Name = "SignUsername"
        SignUsername.Size = New Size(293, 23)
        SignUsername.TabIndex = 5
        ' 
        ' ConfPass
        ' 
        ConfPass.Location = New Point(243, 287)
        ConfPass.Name = "ConfPass"
        ConfPass.PasswordChar = "*"c
        ConfPass.Size = New Size(293, 23)
        ConfPass.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bantayog", 9F)
        Label1.Location = New Point(243, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 12)
        Label1.TabIndex = 9
        Label1.Text = "Confirm Password:"
        ' 
        ' cancel
        ' 
        cancel.Font = New Font("Bantayog", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancel.Location = New Point(243, 330)
        cancel.Name = "cancel"
        cancel.Size = New Size(94, 23)
        cancel.TabIndex = 11
        cancel.Text = "Cancel"
        cancel.UseVisualStyleBackColor = True
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(234), CByte(144), CByte(108))
        ClientSize = New Size(800, 450)
        Controls.Add(cancel)
        Controls.Add(ConfPass)
        Controls.Add(Label1)
        Controls.Add(SignPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(SignUsername)
        Controls.Add(SignUpLabel)
        Controls.Add(signUp)
        Name = "SignUpForm"
        Text = "SignUpForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents signUp As Button
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents SignPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SignUsername As TextBox
    Friend WithEvents ConfPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cancel As Button
End Class
