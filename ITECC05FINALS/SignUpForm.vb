Imports System.Reflection.Metadata.Ecma335
Imports Microsoft.VisualBasic.ApplicationServices
Imports Npgsql


Public Class SignUpForm
    Dim cs As String = "User Id=postgres;Password=inQ7we7x5hy9cUa4;Server=db.djmzenobwshkkbidxgmg.supabase.co;Port=5432;Database=postgres"
    Dim con As New NpgsqlConnection(cs)
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles signUp.Click
        Dim qry = "SELECT * FROM users WHERE username = @param"
        Dim ins = "INSERT INTO users(username, password) VALUES (@param1, @param2)"
        Dim cmd = New NpgsqlCommand(qry, con)
        cmd.Parameters.Add("@param", NpgsqlTypes.NpgsqlDbType.Text)
        cmd.Parameters("@param").Value = SignUsername.Text
        If con.State = ConnectionState.Open Then
            Try
                Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    MsgBox("Username already exists")
                Else
                    reader.Close()
                    If (SignPassword.Text = ConfPass.Text) Then
                        cmd = New NpgsqlCommand(ins, con)
                        cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
                        cmd.Parameters.Add("@param2", NpgsqlTypes.NpgsqlDbType.Text)
                        cmd.Parameters("@param1").Value = SignUsername.Text
                        cmd.Parameters("@param2").Value = SignPassword.Text
                        Dim read = cmd.ExecuteReader()
                        read.Close()
                        LoginForm.Show()
                        Me.Hide()
                    Else
                        MsgBox("Passwords do not match")
                    End If
                End If
                reader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If


    End Sub

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()


    End Sub
End Class