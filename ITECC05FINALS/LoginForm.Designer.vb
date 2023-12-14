<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        username = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        password = New TextBox()
        Login = New Button()
        sign_up = New Button()
        SuspendLayout()
        ' 
        ' username
        ' 
        username.Location = New Point(255, 154)
        username.Name = "username"
        username.Size = New Size(293, 23)
        username.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bantayog", 30F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(315, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 41)
        Label1.TabIndex = 1
        Label1.Text = "Remileon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bantayog", 9F)
        Label2.Location = New Point(255, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 12)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bantayog", 9F)
        Label3.Location = New Point(257, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 12)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' password
        ' 
        password.Location = New Point(255, 234)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(293, 23)
        password.TabIndex = 4
        ' 
        ' Login
        ' 
        Login.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        Login.Cursor = Cursors.Hand
        Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        Login.FlatStyle = FlatStyle.Flat
        Login.Font = New Font("Bantayog", 9F)
        Login.ForeColor = SystemColors.ButtonHighlight
        Login.Location = New Point(427, 289)
        Login.Name = "Login"
        Login.Size = New Size(121, 33)
        Login.TabIndex = 5
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = False
        ' 
        ' sign_up
        ' 
        sign_up.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        sign_up.Cursor = Cursors.Hand
        sign_up.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        sign_up.FlatStyle = FlatStyle.Flat
        sign_up.Font = New Font("Bantayog", 9F)
        sign_up.ForeColor = SystemColors.ButtonHighlight
        sign_up.Location = New Point(255, 289)
        sign_up.Name = "sign_up"
        sign_up.Size = New Size(121, 33)
        sign_up.TabIndex = 6
        sign_up.Text = "Sign-Up"
        sign_up.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(234), CByte(144), CByte(108))
        ClientSize = New Size(800, 450)
        Controls.Add(sign_up)
        Controls.Add(Login)
        Controls.Add(password)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(username)
        Name = "LoginForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents sign_up As Button

End Class
