<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        MainDisplay = New Panel()
        shop = New Button()
        cart = New Button()
        transactions = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' MainDisplay
        ' 
        MainDisplay.AutoScroll = True
        MainDisplay.Location = New Point(0, 83)
        MainDisplay.Name = "MainDisplay"
        MainDisplay.Padding = New Padding(15)
        MainDisplay.Size = New Size(800, 367)
        MainDisplay.TabIndex = 0
        ' 
        ' shop
        ' 
        shop.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        shop.Cursor = Cursors.Hand
        shop.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        shop.FlatStyle = FlatStyle.Flat
        shop.Font = New Font("Bantayog", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        shop.ForeColor = SystemColors.ButtonHighlight
        shop.Location = New Point(314, 29)
        shop.Name = "shop"
        shop.Size = New Size(116, 36)
        shop.TabIndex = 1
        shop.Text = "Shop"
        shop.UseVisualStyleBackColor = False
        ' 
        ' cart
        ' 
        cart.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        cart.Cursor = Cursors.Hand
        cart.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        cart.FlatStyle = FlatStyle.Flat
        cart.Font = New Font("Bantayog", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cart.ForeColor = SystemColors.ButtonHighlight
        cart.Location = New Point(477, 29)
        cart.Name = "cart"
        cart.Size = New Size(116, 36)
        cart.TabIndex = 2
        cart.Text = "Cart"
        cart.UseVisualStyleBackColor = False
        ' 
        ' transactions
        ' 
        transactions.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        transactions.Cursor = Cursors.Hand
        transactions.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        transactions.FlatStyle = FlatStyle.Flat
        transactions.Font = New Font("Bantayog", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        transactions.ForeColor = SystemColors.ButtonHighlight
        transactions.Location = New Point(638, 29)
        transactions.Name = "transactions"
        transactions.Size = New Size(116, 36)
        transactions.TabIndex = 3
        transactions.Text = "Transactions"
        transactions.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bantayog", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 36)
        Label1.TabIndex = 4
        Label1.Text = "Remileon"
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(234), CByte(144), CByte(108))
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(transactions)
        Controls.Add(cart)
        Controls.Add(shop)
        Controls.Add(MainDisplay)
        Name = "HomeForm"
        Text = "HomeForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainDisplay As Panel
    Friend WithEvents shop As Button
    Friend WithEvents cart As Button
    Friend WithEvents transactions As Button
    Friend WithEvents Label1 As Label
End Class
