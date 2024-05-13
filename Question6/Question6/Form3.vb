Public Class Form3


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cbCinnematic.Checked Then
            totalCost += Cinnematic
        End If
        If cbHBI.Checked Then
            totalCost += HBI
        End If
        If cbShowtimer.Checked Then
            totalCost += showtimer
        End If
        If cdLocalStation.Checked Then
            totalCost += localStation
        End If

        MessageBox.Show("Your monthly cable bill is: $" & totalCost.ToString("0.00"))
    End Sub
End Class