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
        lblDisplay = New Label()
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BorderStyle = BorderStyle.Fixed3D
        lblDisplay.Enabled = False
        lblDisplay.FlatStyle = FlatStyle.Popup
        lblDisplay.Font = New Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDisplay.Location = New Point(168, 252)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(437, 159)
        lblDisplay.TabIndex = 0
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.MenuHighlight
        btnStart.FlatStyle = FlatStyle.Popup
        btnStart.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(305, 130)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(157, 72)
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
        Controls.Add(lblDisplay)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnStart As Button

End Class
