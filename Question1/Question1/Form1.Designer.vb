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
        btnMember = New Button()
        btnNonMember = New Button()
        SuspendLayout()
        ' 
        ' btnMember
        ' 
        btnMember.BackColor = SystemColors.Highlight
        btnMember.FlatStyle = FlatStyle.Popup
        btnMember.Font = New Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMember.Location = New Point(287, 97)
        btnMember.Name = "btnMember"
        btnMember.Size = New Size(197, 76)
        btnMember.TabIndex = 0
        btnMember.Text = "Member"
        btnMember.UseVisualStyleBackColor = False
        ' 
        ' btnNonMember
        ' 
        btnNonMember.BackColor = SystemColors.Highlight
        btnNonMember.FlatStyle = FlatStyle.Popup
        btnNonMember.Font = New Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNonMember.Location = New Point(287, 207)
        btnNonMember.Name = "btnNonMember"
        btnNonMember.Size = New Size(197, 76)
        btnNonMember.TabIndex = 1
        btnNonMember.Text = "Non-member"
        btnNonMember.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNonMember)
        Controls.Add(btnMember)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMember As Button
    Friend WithEvents btnNonMember As Button

End Class
