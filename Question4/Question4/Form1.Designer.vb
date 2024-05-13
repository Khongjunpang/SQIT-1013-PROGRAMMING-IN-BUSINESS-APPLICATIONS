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
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.Highlight
        btnStart.FlatStyle = FlatStyle.Popup
        btnStart.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(319, 180)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(176, 74)
        btnStart.TabIndex = 0
        btnStart.Text = "START"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStart As Button

End Class
