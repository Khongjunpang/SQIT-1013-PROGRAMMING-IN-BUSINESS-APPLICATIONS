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
        btn = New Button()
        lblDisplay = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' btn
        ' 
        btn.BackColor = SystemColors.MenuHighlight
        btn.FlatStyle = FlatStyle.Popup
        btn.Font = New Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn.Location = New Point(340, 271)
        btn.Name = "btn"
        btn.Size = New Size(132, 61)
        btn.TabIndex = 0
        btn.Text = "START"
        btn.UseVisualStyleBackColor = False
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BorderStyle = BorderStyle.Fixed3D
        lblDisplay.Font = New Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDisplay.Location = New Point(197, 65)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(415, 93)
        lblDisplay.TabIndex = 1
        lblDisplay.Tag = ""
        lblDisplay.Text = " Ainin Inc"
        lblDisplay.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblDisplay)
        Controls.Add(btn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
