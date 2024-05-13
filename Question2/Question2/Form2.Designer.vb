<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rent
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
        btnLuxury = New Button()
        btnNormal = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnLuxury
        ' 
        btnLuxury.BackColor = SystemColors.MenuHighlight
        btnLuxury.FlatStyle = FlatStyle.Popup
        btnLuxury.Font = New Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLuxury.ForeColor = SystemColors.ActiveCaptionText
        btnLuxury.Location = New Point(174, 271)
        btnLuxury.Name = "btnLuxury"
        btnLuxury.Size = New Size(201, 67)
        btnLuxury.TabIndex = 3
        btnLuxury.Text = "Luxury"
        btnLuxury.UseVisualStyleBackColor = False
        ' 
        ' btnNormal
        ' 
        btnNormal.BackColor = SystemColors.MenuHighlight
        btnNormal.FlatStyle = FlatStyle.Popup
        btnNormal.Font = New Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNormal.ForeColor = SystemColors.ActiveCaptionText
        btnNormal.Location = New Point(404, 271)
        btnNormal.Name = "btnNormal"
        btnNormal.Size = New Size(201, 67)
        btnNormal.TabIndex = 4
        btnNormal.Text = "Normal"
        btnNormal.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(108, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(593, 74)
        Label1.TabIndex = 2
        Label1.Text = "Danial Mirza's Car Rental " & vbCrLf & "Which type of car you pefer to rent?" & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Rent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNormal)
        Controls.Add(btnLuxury)
        Controls.Add(Label1)
        Name = "Rent"
        Text = "Rent"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLuxury As Button
    Friend WithEvents btnNormal As Button
    Friend WithEvents Label1 As Label
End Class
