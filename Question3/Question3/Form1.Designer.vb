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
        btnOrder = New Button()
        SuspendLayout()
        ' 
        ' btnOrder
        ' 
        btnOrder.BackColor = SystemColors.MenuHighlight
        btnOrder.BackgroundImageLayout = ImageLayout.Center
        btnOrder.FlatStyle = FlatStyle.Popup
        btnOrder.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOrder.ForeColor = SystemColors.ControlText
        btnOrder.Location = New Point(313, 157)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(186, 74)
        btnOrder.TabIndex = 0
        btnOrder.Text = "ORDER"
        btnOrder.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnOrder)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnOrder As Button

End Class
