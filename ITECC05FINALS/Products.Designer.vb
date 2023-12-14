<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Label1 = New Label()
        shop = New Button()
        ProductDisplay = New Panel()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(312, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' shop
        ' 
        shop.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        shop.Cursor = Cursors.Hand
        shop.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        shop.FlatStyle = FlatStyle.Flat
        shop.Font = New Font("Bantayog", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        shop.ForeColor = SystemColors.ButtonHighlight
        shop.Location = New Point(12, 22)
        shop.Name = "shop"
        shop.Size = New Size(121, 60)
        shop.TabIndex = 2
        shop.Text = "Pencils"
        shop.UseVisualStyleBackColor = False
        ' 
        ' ProductDisplay
        ' 
        ProductDisplay.Location = New Point(182, 22)
        ProductDisplay.Name = "ProductDisplay"
        ProductDisplay.Size = New Size(606, 416)
        ProductDisplay.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(179), CByte(19), CByte(18))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Bantayog", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(12, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 60)
        Button1.TabIndex = 4
        Button1.Text = "Paint"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Products
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(238), CByte(226), CByte(222))
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ProductDisplay)
        Controls.Add(shop)
        Controls.Add(Label1)
        Name = "Products"
        Text = "Products"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents shop As Button
    Friend WithEvents ProductDisplay As Panel
    Friend WithEvents Button1 As Button
End Class
