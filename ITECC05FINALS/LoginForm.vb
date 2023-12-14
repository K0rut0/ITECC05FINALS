Imports Npgsql

Public Class LoginForm
    Dim cs As String = "User Id=postgres;Password=inQ7we7x5hy9cUa4;Server=db.djmzenobwshkkbidxgmg.supabase.co;Port=5432;Database=postgres"
    Dim con As New NpgsqlConnection(cs)
    Public Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim qry = "SELECT * FROM users WHERE username = @param"
        Dim cmd = New NpgsqlCommand(qry, con)
        cmd.Parameters.Add("@param", NpgsqlTypes.NpgsqlDbType.Text)
        cmd.Parameters("@param").Value = username.Text
        If con.State = ConnectionState.Open Then
            Try
                Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim pass = reader.GetString(2)
                    If pass = password.Text Then
                        HomeForm.currUser = username.Text
                        MsgBox("Logged In")
                        Me.Hide()
                        HomeForm.Show()
                    Else
                        MsgBox("Wrong Password")
                    End If
                    reader.Close()
                Else

                    MsgBox("User does not exist")
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            MsgBox("You are offline")
        End If

    End Sub

    Private Sub sign_up_Click(sender As Object, e As EventArgs) Handles sign_up.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
    End Sub
End Class
