<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblDisplay = New Label()
        btnWholesaler = New Button()
        btnRetailer = New Button()
        SuspendLayout()
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BorderStyle = BorderStyle.Fixed3D
        lblDisplay.Font = New Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDisplay.Location = New Point(189, 71)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(415, 172)
        lblDisplay.TabIndex = 2
        lblDisplay.Tag = ""
        lblDisplay.Text = "What is your status?"
        lblDisplay.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnWholesaler
        ' 
        btnWholesaler.BackColor = SystemColors.MenuHighlight
        btnWholesaler.FlatStyle = FlatStyle.Popup
        btnWholesaler.Font = New Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnWholesaler.Location = New Point(202, 314)
        btnWholesaler.Name = "btnWholesaler"
        btnWholesaler.Size = New Size(177, 50)
        btnWholesaler.TabIndex = 3
        btnWholesaler.Text = "Wholesaler"
        btnWholesaler.UseVisualStyleBackColor = False
        ' 
        ' btnRetailer
        ' 
        btnRetailer.BackColor = SystemColors.MenuHighlight
        btnRetailer.FlatStyle = FlatStyle.Popup
        btnRetailer.Font = New Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRetailer.Location = New Point(409, 314)
        btnRetailer.Name = "btnRetailer"
        btnRetailer.Size = New Size(177, 50)
        btnRetailer.TabIndex = 4
        btnRetailer.Text = "Retailer"
        btnRetailer.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRetailer)
        Controls.Add(btnWholesaler)
        Controls.Add(lblDisplay)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnWholesaler As Button
    Friend WithEvents btnRetailer As Button
End Class
