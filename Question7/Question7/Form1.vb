Public Class Form1
    Dim salesAmount As Double
    Dim commission As Double
    Dim additionalAmount As Double
    Dim totalDue As Double
    Dim travel As Boolean
    Dim workedYear As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        commission = 0
        additionalAmount = 0
        totalDue = 0

        salesAmount = InputBox("Please enter the total sales of the salesperson: ", "Sales of the salesperson", "Enter total sales")
        Dim input As Integer = InputBox("Please enter worked year of the salesperson:", "Worked Year of the Salesperson", "Enter worked year")
        Integer.TryParse(input, workedYear)

        Dim result As DialogResult = MessageBox.Show("Did the salesperson travel before?", "Travel Information", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            travel = True
        ElseIf result = DialogResult.No Then
            travel = False
        End If

        If salesAmount > 0 Then
            If salesAmount < 6000 Then
                commission = salesAmount * 0.1
            ElseIf salesAmount >= 6000 AndAlso salesAmount < 30000 Then
                commission = 600 + (salesAmount - 6000) * 0.13
            ElseIf salesAmount >= 30000 Then
                commission = 3720 + (salesAmount - 30000) * 0.14
            End If

            If salesAmount >= 10000 AndAlso workedYear > 10 Then
                additionalAmount += 500
            End If
            If travel = True Then
                additionalAmount += 700
            End If
            totalDue = commission + additionalAmount
            MessageBox.Show("Commission: $" & commission.ToString("0.00") & vbCrLf &
                            "Additional Amount: $" & additionalAmount.ToString("0.00") & vbCrLf &
                            "Total Due: $" & totalDue.ToString("0.00"))

            lblDisplay.Text = "Commission: $" & commission.ToString("0.00") & vbCrLf &
                            "Additional Amount: $" & additionalAmount.ToString("0.00") & vbCrLf &
                            "Total Due: $" & totalDue.ToString("0.00")
        Else
                MessageBox.Show("Commission: $0.00" & vbCrLf &
                            "Additional Amount: $0.00" & vbCrLf &
                            "Total Due: $0.00")
        End If
    End Sub
End Class
