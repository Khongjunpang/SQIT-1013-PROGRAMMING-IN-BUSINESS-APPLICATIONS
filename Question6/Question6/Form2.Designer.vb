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
        lbl = New Label()
        btnBasic = New Button()
        btnSilver = New Button()
        btnGold = New Button()
        btnDiamond = New Button()
        SuspendLayout()
        ' 
        ' lbl
        ' 
        lbl.BackColor = SystemColors.ButtonFace
        lbl.BorderStyle = BorderStyle.Fixed3D
        lbl.FlatStyle = FlatStyle.Popup
        lbl.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl.Location = New Point(104, 82)
        lbl.Name = "lbl"
        lbl.Size = New Size(580, 58)
        lbl.TabIndex = 1
        lbl.Text = "Which package you want to selected?"
        ' 
        ' btnBasic
        ' 
        btnBasic.BackColor = SystemColors.MenuHighlight
        btnBasic.FlatStyle = FlatStyle.Popup
        btnBasic.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBasic.Location = New Point(200, 211)
        btnBasic.Name = "btnBasic"
        btnBasic.Size = New Size(138, 60)
        btnBasic.TabIndex = 2
        btnBasic.Text = "BASIC"
        btnBasic.UseVisualStyleBackColor = False
        ' 
        ' btnSilver
        ' 
        btnSilver.BackColor = SystemColors.MenuHighlight
        btnSilver.FlatStyle = FlatStyle.Popup
        btnSilver.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSilver.Location = New Point(448, 211)
        btnSilver.Name = "btnSilver"
        btnSilver.Size = New Size(138, 60)
        btnSilver.TabIndex = 3
        btnSilver.Text = "SILVER"
        btnSilver.UseVisualStyleBackColor = False
        ' 
        ' btnGold
        ' 
        btnGold.BackColor = SystemColors.MenuHighlight
        btnGold.FlatStyle = FlatStyle.Popup
        btnGold.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGold.Location = New Point(200, 306)
        btnGold.Name = "btnGold"
        btnGold.Size = New Size(138, 60)
        btnGold.TabIndex = 4
        btnGold.Text = "GOLD"
        btnGold.UseVisualStyleBackColor = False
        ' 
        ' btnDiamond
        ' 
        btnDiamond.BackColor = SystemColors.MenuHighlight
        btnDiamond.FlatStyle = FlatStyle.Popup
        btnDiamond.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDiamond.Location = New Point(448, 306)
        btnDiamond.Name = "btnDiamond"
        btnDiamond.Size = New Size(138, 60)
        btnDiamond.TabIndex = 5
        btnDiamond.Text = "DIAMOND"
        btnDiamond.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDiamond)
        Controls.Add(btnGold)
        Controls.Add(btnSilver)
        Controls.Add(btnBasic)
        Controls.Add(lbl)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbl As Label
    Friend WithEvents btnBasic As Button
    Friend WithEvents btnSilver As Button
    Friend WithEvents btnGold As Button
    Friend WithEvents btnDiamond As Button
End Class
