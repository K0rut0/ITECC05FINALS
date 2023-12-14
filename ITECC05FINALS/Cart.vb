Imports System.Net
Imports Npgsql

Public Class Cart
    Dim cs As String = "User Id=postgres;Password=inQ7we7x5hy9cUa4;Server=db.djmzenobwshkkbidxgmg.supabase.co;Port=5432;Database=postgres"
    Dim con As New NpgsqlConnection(cs)
    Public flowLayoutPanel As New FlowLayoutPanel()
    Dim list As New List(Of cartItem)
    Dim cost As Double = 0
    Dim shipCost As Double = 0
    Dim prodDiscount As Double = 0
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry = "SELECT * FROM carts WHERE owner = @param1"
        Dim prdQry = "SELECT * FROM products WHERE product_name = @param1"
        con.Open()
        If con.State = ConnectionState.Open Then
            Dim cmd = New NpgsqlCommand(qry, con)
            cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
            cmd.Parameters("@param1").Value = HomeForm.currUser
            Dim reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Dim temp As New cartItem
                    temp.productName = reader("product_name").ToString()
                    temp.quantity = Convert.ToDouble(reader("quantity"))
                    list.Add(temp)
                End While
            End If
            reader.Close()
            For i As Int128 = 0 To list.Count - 1
                Dim prodCmd = New NpgsqlCommand(prdQry, con)
                prodCmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
                prodCmd.Parameters("@param1").Value = list(i).productName

                Dim prodRdr = prodCmd.ExecuteReader()
                prodRdr.Read()
                list(i).itemPrice = Convert.ToDouble(prodRdr("product_price"))
                list(i).imgUrl = prodRdr("product_image")
                list(i).total = list(i).quantity * list(i).itemPrice
                cost += list(i).total
                prodRdr.Close()
            Next
            reader.Close()
        End If

        flowLayoutPanel.Dock = DockStyle.Fill
        flowLayoutPanel.AutoScroll = True
        CartPanel.Controls.Add(flowLayoutPanel)
        shipCost = list.Count * 10

        For i As Int128 = 0 To list.Count - 1
            Dim productPanel As New Panel()
            productPanel.BorderStyle = BorderStyle.FixedSingle
            productPanel.Width = 150
            productPanel.Height = 230
            productPanel.Name = "p" + i.ToString()
            Dim pictureBox As New PictureBox()
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Try
                ' Download the image from the URL
                Dim webClient As New WebClient()
                Dim imageData As Byte() = webClient.DownloadData(list(i).imgUrl.ToString())

                ' Convert the byte array to an Image
                Using ms As New IO.MemoryStream(imageData)
                    Dim imageFromUrl As Image = Image.FromStream(ms)

                    ' Assign the downloaded image to the PictureBox
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage ' Adjust size mode as needed
                    pictureBox.Image = imageFromUrl
                End Using
            Catch ex As Exception
                ' Handle exceptions (e.g., URL not found, network issues, etc.)
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
            pictureBox.Width = 100 ' Set width as needed
            pictureBox.Height = 100 ' Set height as needed

            Dim nameLabel As New Label()
            nameLabel.Text = list(i).productName
            nameLabel.Font = New Font("Bantayog", 9.0F)
            nameLabel.Location = New Point(25, 110)

            Dim descriptionLabel As New Label()
            descriptionLabel.Text = list(i).itemPrice.ToString() + " Pesos"
            descriptionLabel.AutoSize = True
            descriptionLabel.Location = New Point(25, 130)
            descriptionLabel.Font = New Font("Bantayog", 9.0F)

            Dim quant As New Label()
            quant.Text = "x " + list(i).quantity
            quant.AutoSize = True
            quant.Location = New Point(25, 150)
            quant.Font = New Font("Bantayog", 9.0F)

            Dim tot As New Label()
            tot.Text = list(i).total
            tot.AutoSize = True
            tot.Location = New Point(25, 170)
            tot.Font = New Font("Bantayog", 9.0F)

            Dim deleteEntry As New Button()
            deleteEntry.BackColor = Color.FromArgb(179, 19, 18)
            deleteEntry.Width = 90
            deleteEntry.Text = "Remove Item"
            deleteEntry.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
            deleteEntry.FlatStyle = FlatStyle.Flat
            deleteEntry.ForeColor = SystemColors.ButtonHighlight
            deleteEntry.Font = New Font("Bantayog", 7.0F)
            deleteEntry.Location = New Point(5, 190)
            deleteEntry.Name = i.ToString()

            AddHandler deleteEntry.Click, AddressOf Me.deleteItem

            productPanel.Controls.Add(nameLabel)
            productPanel.Controls.Add(descriptionLabel)
            productPanel.Controls.Add(pictureBox)
            productPanel.Controls.Add(quant)
            productPanel.Controls.Add(tot)
            productPanel.Controls.Add(deleteEntry)

            productPanel.Anchor = AnchorStyles.None
            flowLayoutPanel.Controls.Add(productPanel)
        Next

        subTotal.Text = cost
        discount.Text = prodDiscount
        shipping.Text = shipCost

        gTotal.Text = (cost + prodDiscount + shipCost)
    End Sub

    Public Sub deleteItem(sender As Object, e As EventArgs)
        Dim button = DirectCast(sender, Button)
        Dim index = CInt(button.Name)
        If con.State = ConnectionState.Open Then
            Try
                Dim qry = "DELETE FROM carts WHERE (owner = @param1 AND product_name = @param2)"
                Dim cmd = New NpgsqlCommand(qry, con)
                cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
                cmd.Parameters.Add("@param2", NpgsqlTypes.NpgsqlDbType.Text)
                cmd.Parameters("@param1").Value = HomeForm.currUser
                cmd.Parameters("@param2").Value = list(index).productName
                Dim reader = cmd.ExecuteReader()
                reader.Read()
                reader.Close()
                list.Clear()
                con.Close()
                cost = 0
                shipCost = 0
                prodDiscount = 0
                flowLayoutPanel.Controls.Clear()
                Cart_Load(sender, e)
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If


    End Sub

    Private Sub checkOut_Click(sender As Object, e As EventArgs) Handles checkOut.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim dateString = CDate(DateTime.Now.ToString("yyyy-MM-dd"))
        Dim qry = "INSERT INTO transactions (owner, total_items, total_cost, date_created, status) VALUES (@param1, @param2, @param3, @param4, @param5)"
        Dim cmd = New NpgsqlCommand(qry, con)
        cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
        cmd.Parameters.Add("@param2", NpgsqlTypes.NpgsqlDbType.Text)
        cmd.Parameters.Add("@param3", NpgsqlTypes.NpgsqlDbType.Text)
        cmd.Parameters.Add("@param4", NpgsqlTypes.NpgsqlDbType.Date)
        cmd.Parameters.Add("@param5", NpgsqlTypes.NpgsqlDbType.Integer)
        cmd.Parameters("@param1").Value = HomeForm.currUser
        cmd.Parameters("@param2").Value = list.Count.ToString()
        cmd.Parameters("@param3").Value = gTotal.Text
        cmd.Parameters("@param4").Value = dateString
        cmd.Parameters("@param5").Value = 0

        Try
            Dim reader = cmd.ExecuteReader()
            reader.Read()
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        qry = "DELETE FROM carts WHERE (owner = @param1)"
        cmd = New NpgsqlCommand(qry, con)
        cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
        cmd.Parameters("@param1").Value = HomeForm.currUser

        Try
            Dim reader = cmd.ExecuteReader()
            reader.Read()
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        con.Close()
        list.Clear()
        cost = 0
        shipCost = 0
        prodDiscount = 0
        flowLayoutPanel.Controls.Clear()
        Cart_Load(sender, e)
    End Sub
End Class

Public Class cartItem
    Public Property productName As String
    Public Property quantity As String
    Public Property itemPrice As Double
    Public Property imgUrl As String
    Public Property total As Double
End Class