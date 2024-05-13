<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl = New Label()
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' lbl
        ' 
        lbl.BackColor = SystemColors.ControlDark
        lbl.BorderStyle = BorderStyle.Fixed3D
        lbl.FlatStyle = FlatStyle.Popup
        lbl.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl.Location = New Point(159, 98)
        lbl.Name = "lbl"
        lbl.Size = New Size(486, 58)
        lbl.TabIndex = 0
        lbl.Text = "Luqman Brothers Cable Company "
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.MenuHighlight
        btnStart.FlatStyle = FlatStyle.Popup
        btnStart.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(332, 246)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(125, 60)
        btnStart.TabIndex = 1
        btnStart.Text = "START"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnStart)
        Controls.Add(lbl)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbl As Label
    Friend WithEvents btnStart As Button

End Class
