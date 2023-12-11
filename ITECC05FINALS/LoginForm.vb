

Public Class LoginForm
    Public user As String
    Public Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim uName As String = username.Text
        Dim pWord As String = password.Text
        user = uName
        Me.Hide()
        HomeForm.Show()
    End Sub


End Class
