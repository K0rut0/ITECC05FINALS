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
        Button1 = New Button()
        SignUpLabel = New Label()
        SignPassword = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        SignUsername = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(442, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 23)
        Button1.TabIndex = 0
        Button1.Text = "Sign-Up"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SignUpLabel
        ' 
        SignUpLabel.AutoSize = True
        SignUpLabel.Font = New Font("Segoe UI", 30F)
        SignUpLabel.Location = New Point(301, 38)
        SignUpLabel.Name = "SignUpLabel"
        SignUpLabel.Size = New Size(163, 54)
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
        Label3.Location = New Point(243, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 7
        Label3.Text = "Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(243, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(243, 287)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(293, 23)
        TextBox1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(243, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 9
        Label1.Text = "Confirm Password:"
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(234), CByte(144), CByte(108))
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(SignPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(SignUsername)
        Controls.Add(SignUpLabel)
        Controls.Add(Button1)
        Name = "SignUpForm"
        Text = "SignUpForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SignUpLabel As Label
    Friend WithEvents SignPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SignUsername As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
