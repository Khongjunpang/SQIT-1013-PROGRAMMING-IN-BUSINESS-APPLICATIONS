Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub
End Class
