Public Class HomeForm
    Public Property currUser As String
    Public Property currUserIId As Int64
    Dim products As New Products()
    Dim cartForm As New Cart()
    Dim transac As New Transaction()
    Public Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        products = New Products()
        products.TopLevel = False
        products.Parent = MainDisplay
        products.FormBorderStyle = FormBorderStyle.None
        products.ControlBox = False
        products.Dock = DockStyle.Fill
        products.Show()
    End Sub

    Public Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        cartForm = New Cart()
        cartForm.TopLevel = False
        cartForm.Parent = MainDisplay
        cartForm.FormBorderStyle = FormBorderStyle.None
        cartForm.ControlBox = False
        cartForm.Dock = DockStyle.Fill
        cartForm.Show()
        products.Hide()
        transac.Hide()
    End Sub

    Private Sub shop_Click_1(sender As Object, e As EventArgs) Handles shop.Click

        products.TopLevel = False
        products.Parent = MainDisplay
        products.FormBorderStyle = FormBorderStyle.None
        products.ControlBox = False
        products.Dock = DockStyle.Fill
        products.Show()
        cartForm.Hide()
        transac.Hide()
    End Sub

    Private Sub transactions_Click(sender As Object, e As EventArgs) Handles transactions.Click
        transac = New Transaction()
        transac.TopLevel = False
        transac.Parent = MainDisplay
        transac.FormBorderStyle = FormBorderStyle.None
        transac.ControlBox = False
        transac.Dock = DockStyle.Fill
        transac.Show()
        cartForm.Hide()
        products.Hide()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()


    End Sub


End Class