Option Strict On
Option Explicit On
Imports System.Net
Imports Npgsql

Public Class Pencils
    Dim cs As String = "User Id=postgres;Password=inQ7we7x5hy9cUa4;Server=db.djmzenobwshkkbidxgmg.supabase.co;Port=5432;Database=postgres"
    Dim con As New NpgsqlConnection(cs)
    Dim flowLayoutPanel As New FlowLayoutPanel()
    Dim list As New List(Of ProductEntry)
    Private Sub Pencils_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flowLayoutPanel.Dock = DockStyle.Fill
        flowLayoutPanel.AutoScroll = True

        Me.Controls.Add(flowLayoutPanel)

        con.Open()

        Dim qry = "SELECT * FROM products WHERE product_type = 'Pencil'"
        Dim cmd = New NpgsqlCommand(qry, con)
        Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
        Dim i As Int128 = 0
        If reader.HasRows Then
            While reader.Read()
                Dim productPanel As New Panel()
                productPanel.BorderStyle = BorderStyle.None
                productPanel.Width = 150
                productPanel.Height = 200

                Dim pictureBox As New PictureBox()
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Try
                    ' Download the image from the URL
                    Dim webClient As New WebClient()
                    Dim imageData As Byte() = webClient.DownloadData(reader("product_image").ToString())

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

                Dim product As New ProductEntry()
                product.productName = reader("product_name").ToString()
                product.productType = reader("product_type").ToString()
                product.productCost = reader("product_price").ToString()

                list.Add(product)

                product.productCost = reader("product_price").ToString() + "Pesos"

                Dim nameLabel As New Label()
                nameLabel.Text = product.productName
                nameLabel.Font = New Font("Bantayog", 9.0F)
                nameLabel.Location = New Point(25, 110)

                Dim descriptionLabel As New Label()
                descriptionLabel.Text = product.productCost
                descriptionLabel.AutoSize = True
                descriptionLabel.Location = New Point(25, 130)
                descriptionLabel.Font = New Font("Bantayog", 9.0F)

                Dim addToCart As New Button()
                addToCart.BackColor = Color.FromArgb(179, 19, 18)
                addToCart.Width = 90
                addToCart.Text = "Add to Cart"
                addToCart.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
                addToCart.FlatStyle = FlatStyle.Flat
                addToCart.ForeColor = SystemColors.ButtonHighlight
                addToCart.Font = New Font("Bantayog", 7.0F)
                addToCart.Location = New Point(5, 150)
                addToCart.Name = i.ToString()
                i = i + 1
                AddHandler addToCart.Click, AddressOf Me.AddToCart
                productPanel.Controls.Add(nameLabel)
                productPanel.Controls.Add(descriptionLabel)
                productPanel.Controls.Add(pictureBox)
                productPanel.Controls.Add(addToCart)
                productPanel.Anchor = AnchorStyles.None

                flowLayoutPanel.Controls.Add(productPanel)
            End While
            reader.Close()

        End If
    End Sub
    Public Sub AddToCart(sender As Object, e As EventArgs)
        Dim button = DirectCast(sender, Button)
        Dim index = CInt(button.Name)

        If con.State = ConnectionState.Open Then
            Dim qry = "INSERT INTO carts (owner, product_name, quantity, status) VALUES (@param1, @param2, @param3, @param4)"
            Dim chk = "SELECT * FROM carts WHERE (product_name = @param1 AND owner = @param2)"
            Dim cmd = New NpgsqlCommand(chk, con)
            cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
            cmd.Parameters.Add("@param2", NpgsqlTypes.NpgsqlDbType.Text)
            cmd.Parameters("@param2").Value = HomeForm.currUser
            cmd.Parameters("@param1").Value = list(index).productName
            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Item already in cart")
                reader.Close()
            Else
                Try
                    reader.Close()
                    cmd = New NpgsqlCommand(qry, con)
                    cmd.Parameters.Add("@param1", NpgsqlTypes.NpgsqlDbType.Text)
                    cmd.Parameters.Add("@param2", NpgsqlTypes.NpgsqlDbType.Text)
                    cmd.Parameters.Add("@param3", NpgsqlTypes.NpgsqlDbType.Text)
                    cmd.Parameters.Add("@param4", NpgsqlTypes.NpgsqlDbType.Text)
                    cmd.Parameters("@param1").Value = HomeForm.currUser
                    cmd.Parameters("@param2").Value = list(index).productName
                    cmd.Parameters("@param3").Value = 1.ToString()
                    cmd.Parameters("@param4").Value = "open"
                    Dim rdr As NpgsqlDataReader = cmd.ExecuteReader()
                    rdr.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try

            End If

            reader.Close()
        End If
    End Sub
End Class


Public Class ProductEntry
    Public Property productType As String
    Public Property productName As String
    Public Property productCost As String

End Class