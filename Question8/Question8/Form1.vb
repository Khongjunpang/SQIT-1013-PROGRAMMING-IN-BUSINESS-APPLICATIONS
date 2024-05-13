Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim form2 As New Form2()
        form2.show()
        Me.Hide()
    End Sub
End Class
