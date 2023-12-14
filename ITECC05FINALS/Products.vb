Imports Npgsql

Public Class Products
    Dim cs As String = "User Id=postgres;Password=inQ7we7x5hy9cUa4;Server=db.djmzenobwshkkbidxgmg.supabase.co;Port=5432;Database=postgres"
    Dim con As New NpgsqlConnection(cs)
    Dim flowLayoutPanel As New FlowLayoutPanel()

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductDisplay.AutoScroll = True
        ProductDisplay.Width = 600
        ProductDisplay.Height = 300
        ProductDisplay.AutoScrollMinSize = New Size(500, 200)
        Dim products As New Pencils()
        products.TopLevel = False
        products.Parent = ProductDisplay
        products.FormBorderStyle = FormBorderStyle.None
        products.ControlBox = False
        products.Dock = DockStyle.Fill
        products.BringToFront()
        products.Show()
    End Sub

    Private Sub shop_Click(sender As Object, e As EventArgs) Handles shop.Click
        Dim products As New Pencils()
        products.TopLevel = False
        products.Parent = ProductDisplay
        products.FormBorderStyle = FormBorderStyle.None
        products.ControlBox = False
        products.Dock = DockStyle.Fill
        products.BringToFront()
        products.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim products As New Paints()
        products.TopLevel = False
        products.Parent = ProductDisplay
        products.FormBorderStyle = FormBorderStyle.None
        products.ControlBox = False
        products.Dock = DockStyle.Fill
        products.BringToFront()
        products.Show()
    End Sub
End Class
