<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction
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
        transPanel = New Panel()
        SuspendLayout()
        ' 
        ' transPanel
        ' 
        transPanel.Location = New Point(14, 12)
        transPanel.Name = "transPanel"
        transPanel.Size = New Size(774, 419)
        transPanel.TabIndex = 0
        ' 
        ' Transaction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(238), CByte(226), CByte(222))
        ClientSize = New Size(800, 450)
        Controls.Add(transPanel)
        Name = "Transaction"
        Text = "transactions"
        ResumeLayout(False)
    End Sub

    Friend WithEvents transPanel As Panel
End Class
