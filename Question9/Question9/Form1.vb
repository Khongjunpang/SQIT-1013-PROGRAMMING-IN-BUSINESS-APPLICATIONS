Public Class Form1
    Dim blackQuantity As Integer
    Dim navyQuantity As Integer
    Dim redQuantity As Integer
    Dim creditCard As Boolean
    Dim discount As Double
    Dim totalDue As Double

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblDisplay.Text = ""
        blackQuantity = InputBox("Please enter the quantity of black jackets:", "Black Jackets", "Enter the quantity")
        navyQuantity = InputBox("Please enter the quantity of navy jackets:", "Navy Jackets", "Enter the quantity")
        redQuantity = InputBox("Please enter the quantity of red jackets:", "Red Jackets", "Enter the quantity")

        ' Calculate total cost for each type of jacket
        Dim totalCostBlack As Double = blackQuantity * 45.99
        Dim totalCostNavy As Double = navyQuantity * 39.99
        Dim totalCostRed As Double = redQuantity * 39.99

        ' Calculate total cost of all jackets
        Dim totalCostAll As Double = totalCostBlack + totalCostNavy + totalCostRed

        Dim result As DialogResult = MessageBox.Show("Did you pay using Jacket Credit Card?", "Jacket Credit Card", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            creditCard = True
        Else
            creditCard = False
        End If

        If creditCard = True Then
            discount = totalCostAll * 0.1
        ElseIf blackQuantity + navyQuantity + redQuantity >= 2 Then
            discount = totalCostAll * 0.05
        End If

        totalDue = totalCostAll - discount
        lblDisplay.Text = "Total Cost of Black Jackets: $" & totalCostBlack.ToString("0.00") & vbCrLf &
                         "Total Cost of Navy Jackets: $" & totalCostNavy.ToString("0.00") & vbCrLf &
                         "Total Cost of Red Jackets: $" & totalCostRed.ToString("0.00") & vbCrLf &
                         "Total Cost of All Jackets: $" & totalCostAll.ToString("0.00") & vbCrLf &
                         "Discount: $" & discount.ToString("0.00") & vbCrLf &
                         "Total Due: $" & totalDue.ToString("0.00")
    End Sub
End Class
