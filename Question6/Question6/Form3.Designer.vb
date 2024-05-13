<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        cbCinnematic = New CheckBox()
        cbHBI = New CheckBox()
        cbShowtimer = New CheckBox()
        cdLocalStation = New CheckBox()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' lbl
        ' 
        lbl.BackColor = SystemColors.ButtonFace
        lbl.BorderStyle = BorderStyle.Fixed3D
        lbl.FlatStyle = FlatStyle.Popup
        lbl.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl.Location = New Point(113, 64)
        lbl.Name = "lbl"
        lbl.Size = New Size(580, 58)
        lbl.TabIndex = 2
        lbl.Text = "Which package you want to selected?"
        ' 
        ' cbCinnematic
        ' 
        cbCinnematic.AutoSize = True
        cbCinnematic.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbCinnematic.Location = New Point(136, 165)
        cbCinnematic.Name = "cbCinnematic"
        cbCinnematic.Size = New Size(307, 27)
        cbCinnematic.TabIndex = 3
        cbCinnematic.Text = "Cinnematic movie channels"
        cbCinnematic.UseVisualStyleBackColor = True
        ' 
        ' cbHBI
        ' 
        cbHBI.AutoSize = True
        cbHBI.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbHBI.Location = New Point(136, 215)
        cbHBI.Name = "cbHBI"
        cbHBI.Size = New Size(230, 27)
        cbHBI.TabIndex = 4
        cbHBI.Text = "HBI movie channels"
        cbHBI.UseVisualStyleBackColor = True
        ' 
        ' cbShowtimer
        ' 
        cbShowtimer.AutoSize = True
        cbShowtimer.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbShowtimer.Location = New Point(136, 263)
        cbShowtimer.Name = "cbShowtimer"
        cbShowtimer.Size = New Size(307, 27)
        cbShowtimer.TabIndex = 5
        cbShowtimer.Text = "Showtimer movie channels "
        cbShowtimer.UseVisualStyleBackColor = True
        ' 
        ' cdLocalStation
        ' 
        cdLocalStation.AutoSize = True
        cdLocalStation.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cdLocalStation.Location = New Point(136, 312)
        cdLocalStation.Name = "cdLocalStation"
        cdLocalStation.Size = New Size(175, 27)
        cdLocalStation.TabIndex = 6
        cdLocalStation.Text = "Local Station"
        cdLocalStation.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.MenuHighlight
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(324, 362)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(145, 60)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "CONFIRM"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(cdLocalStation)
        Controls.Add(cbShowtimer)
        Controls.Add(cbHBI)
        Controls.Add(cbCinnematic)
        Controls.Add(lbl)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbl As Label
    Friend WithEvents cbCinnematic As CheckBox
    Friend WithEvents cbHBI As CheckBox
    Friend WithEvents cbShowtimer As CheckBox
    Friend WithEvents cdLocalStation As CheckBox
    Friend WithEvents btnSubmit As Button
End Class
