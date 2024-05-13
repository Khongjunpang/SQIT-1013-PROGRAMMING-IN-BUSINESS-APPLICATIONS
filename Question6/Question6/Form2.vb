Public Class Form2

    Private Sub btnBasic_Click(sender As Object, e As EventArgs) Handles btnBasic.Click
        totalCost += basic
        NextPage()
    End Sub

    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        totalCost += silver
        NextPage()
    End Sub

    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        totalCost += gold
        NextPage()
    End Sub

    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click
        totalCost += diamond
        NextPage()
    End Sub

    Private Function NextPage()
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Function


End Class