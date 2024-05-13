Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim form2 As New Rent()
        form2.Show()
        Me.Hide()
    End Sub


End Class
