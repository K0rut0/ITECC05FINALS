<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        CartPanel = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        subTotal = New Label()
        shipping = New Label()
        Label6 = New Label()
        discount = New Label()
        Label8 = New Label()
        gTotal = New Label()
        Label10 = New Label()
        checkOut = New Button()
        SuspendLayout()
        ' 
        ' CartPanel
        ' 
        CartPanel.Location = New Point(12, 70)
        CartPanel.Name = "CartPanel"
        CartPanel.Size = New Size(520, 370)
        CartPanel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bantayog", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 49)
        Label1.TabIndex = 1
        Label1.Text = "Your Cart"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bantayog", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ImageAlign = ContentAlignment.MiddleRight
        Label3.Location = New Point(538, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 25)
        Label3.TabIndex = 3
        Label3.Text = "Subtotal"
        ' 
        ' subTotal
        ' 
        subTotal.AutoSize = True
        subTotal.Font = New Font("Bantayog", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subTotal.ImageAlign = ContentAlignment.MiddleRight
        subTotal.Location = New Point(689, 70)
        subTotal.Name = "subTotal"
        subTotal.Size = New Size(19, 25)
        subTotal.TabIndex = 4
        subTotal.Text = " "
        ' 
        ' shipping
        ' 
        shipping.AutoSize = True
        shipping.Font = New Font("Bantayog", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        shipping.ImageAlign = ContentAlignment.MiddleRight
        shipping.Location = New Point(689, 111)
        shipping.Name = "shipping"
        shipping.Size = New Size(11, 16)
        shipping.TabIndex = 6
        shipping.Text = " "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bantayog", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ImageAlign = ContentAlignment.MiddleRight
        Label6.Location = New Point(538, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 16)
        Label6.TabIndex = 5
        Label6.Text = "SHIPPING COST"
        ' 
        ' discount
        ' 
        discount.AutoSize = True
        discount.Font = New Font("Bantayog", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        discount.ImageAlign = ContentAlignment.MiddleRight
        discount.Location = New Point(689, 141)
        discount.Name = "discount"
        discount.Size = New Size(11, 16)
        discount.TabIndex = 8
        discount.Text = " "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bantayog", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ImageAlign = ContentAlignment.MiddleRight
        Label8.Location = New Point(538, 141)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 16)
        Label8.TabIndex = 7
        Label8.Text = "DISCOUNT"
        ' 
        ' gTotal
        ' 
        gTotal.AutoSize = True
        gTotal.Font = New Font("Bantayog", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gTotal.ImageAlign = ContentAlignment.MiddleRight
        gTotal.Location = New Point(689, 170)
        gTotal.Name = "gTotal"
        gTotal.Size = New Size(19, 25)
        gTotal.TabIndex = 10
        gTotal.Text = " "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Bantayog", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ImageAlign = ContentAlignment.MiddleRight
        Label10.Location = New Point(538, 170)
        Label10.Name = "Label10"
        Label10.Size = New Size(145, 25)
        Label10.TabIndex = 9
        Label10.Text = "Grand Total"
        ' 
        ' checkOut
        ' 
        checkOut.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        checkOut.Cursor = Cursors.Hand
        checkOut.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        checkOut.FlatStyle = FlatStyle.Flat
        checkOut.Font = New Font("Bantayog", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkOut.ForeColor = SystemColors.ButtonHighlight
        checkOut.Location = New Point(538, 213)
        checkOut.Name = "checkOut"
        checkOut.Size = New Size(208, 60)
        checkOut.TabIndex = 11
        checkOut.Text = "Checkout"
        checkOut.UseVisualStyleBackColor = False
        ' 
        ' Cart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(238), CByte(226), CByte(222))
        ClientSize = New Size(800, 450)
        Controls.Add(checkOut)
        Controls.Add(gTotal)
        Controls.Add(Label10)
        Controls.Add(discount)
        Controls.Add(Label8)
        Controls.Add(shipping)
        Controls.Add(Label6)
        Controls.Add(subTotal)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(CartPanel)
        Name = "Cart"
        Text = "Cart"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CartPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents subTotal As Label
    Friend WithEvents shipping As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents discount As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gTotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents checkOut As Button
End Class
