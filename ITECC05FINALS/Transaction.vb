
Imports Npgsql
Public Class Transaction
    Dim cs As String = "User Id=postgres;Password=inQ7we7x5hy9cUa4;Server=db.djmzenobwshkkbidxgmg.supabase.co;Port=5432;Database=postgres"
    Dim con As New NpgsqlConnection(cs)
    Public flowLayoutPanel As New FlowLayoutPanel()
    Dim list As New List(Of transClass)
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim qry = "SELECT * FROM transactions WHERE owner = @param1"
        Dim cmd = New NpgsqlCommand(qry, con)
        cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
        cmd.Parameters("@param1").Value = HomeForm.currUser

        If con.State = ConnectionState.Open Then
            Try
                Dim reader = cmd.ExecuteReader()
                While reader.Read()
                    Dim temp As New transClass
                    temp.id = reader("id")
                    temp.totalItems = reader("total_items")
                    temp.totalCost = reader("total_cost")
                    temp.status = reader("status")
                    temp.dateS = reader("date_created")
                    list.Add(temp)
                End While
                reader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

            flowLayoutPanel.Dock = DockStyle.None

            flowLayoutPanel.AutoScroll = True
            flowLayoutPanel.Height = transPanel.Height - 70
            flowLayoutPanel.Width = transPanel.Width
            flowLayoutPanel.Location = New Point(0, 0)
            transPanel.Padding = New Padding(0, 0, 0, 15)
            transPanel.Controls.Add(flowLayoutPanel)

            For i As Int128 = 0 To list.Count - 1
                Dim tPanel As New Panel()
                tPanel.BorderStyle = BorderStyle.FixedSingle
                tPanel.Width = 700
                tPanel.Height = transPanel.Height / 3
                tPanel.BackColor = Color.FromArgb(234, 144, 108)

                Dim nameLabel As New Label()
                nameLabel.AutoSize = True
                nameLabel.Text = list(i).dateS
                nameLabel.Font = New Font("Bantayog", 18.0F)
                nameLabel.Location = New Point(25, 25)

                Dim details As New Label()
                details.AutoSize = True
                details.Text = "Number of items: " + list(i).totalItems
                details.Font = New Font("Bantayog", 9.0F)
                details.Location = New Point(25, 60)

                Dim totalC As New Label()
                totalC.AutoSize = True
                totalC.Text = "Total Cost: " + list(i).totalCost
                totalC.Font = New Font("Bantayog", 9.0F)
                totalC.Location = New Point(25, 80)

                Dim stat As New Label()
                stat.AutoSize = True
                If list(i).status = 0 Then
                    stat.Text = "Pending"
                Else
                    stat.Text = "Recieved"
                End If
                stat.Font = New Font("Bantayog", 18.0F)
                stat.Location = New Point(500, 25)

                Dim updateStatus As New Button()
                updateStatus.BackColor = Color.FromArgb(179, 19, 18)
                updateStatus.AutoSize = True
                updateStatus.Text = "Recieved"
                updateStatus.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
                updateStatus.FlatStyle = FlatStyle.Flat
                updateStatus.ForeColor = SystemColors.ButtonHighlight
                updateStatus.Font = New Font("Bantayog", 13.0F)
                updateStatus.Location = New Point(500, 70)
                updateStatus.Name = i.ToString()

                AddHandler updateStatus.Click, AddressOf Me.updateStatus


                tPanel.Controls.Add(nameLabel)
                tPanel.Controls.Add(details)
                tPanel.Controls.Add(totalC)
                tPanel.Controls.Add(stat)
                tPanel.Controls.Add(updateStatus)

                flowLayoutPanel.Controls.Add(tPanel)
            Next
        End If

    End Sub
    Public Sub updateStatus(sender As Object, e As EventArgs)
        Dim button = DirectCast(sender, Button)
        Dim index = CInt(button.Name)

        Dim qry = "UPDATE transactions SET status = 1 WHERE id = @param1"
        Dim cmd = New NpgsqlCommand(qry, con)
        cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Integer)
        cmd.Parameters("@param1").Value = list(index).id

        If con.State = ConnectionState.Open Then
            Try
                Dim reader = cmd.ExecuteReader()
                reader.Read()
                reader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

        con.Close()
        list.Clear()
        flowLayoutPanel.Controls.Clear()
        Transactions_Load(sender, e)
    End Sub
End Class

Public Class transClass
    Public Property id As Int64
    Public Property totalItems As String
    Public Property totalCost As String
    Public Property status As Int16
    Public Property dateS As String


End Class