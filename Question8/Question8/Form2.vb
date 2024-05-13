Public Class Form2
    Dim status As String
    Dim quantity As Integer
    Dim pricePerUnit As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRetailer.Click
        status = "Retailer"
        calCost()
    End Sub

    Private Sub btnWholesaler_Click(sender As Object, e As EventArgs) Handles btnWholesaler.Click
        status = "Wholesaler"
        calCost()
    End Sub

    Private Function calCost()
        lblDisplay.Text = ""
        Dim result As String = InputBox("Please enter the quantity of the units ordered", "Units ordered by user", "Enter the units ordered")
        Integer.TryParse(result, quantity)
        If status = "Wholesaler" Then
            If quantity >= 1 AndAlso quantity <= 50 Then
                pricePerUnit = 15
            ElseIf quantity >= 51 AndAlso quantity <= 150 Then
                pricePerUnit = 13
            Else
                pricePerUnit = 10
            End If
        ElseIf status = "Retailer" Then
            If quantity >= 1 AndAlso quantity <= 25 Then
                pricePerUnit = 22
            Else
                pricePerUnit = 18
            End If
        End If
        ' Calculate total price
        Dim totalPrice As Double = quantity * pricePerUnit

        ' Display result
        MessageBox.Show("Customer Status: " & status & vbCrLf &
                        "Quantity: " & quantity.ToString() & vbCrLf &
                        "Price per unit: $" & pricePerUnit.ToString("0.00") & vbCrLf &
                        "Total Price: $" & totalPrice.ToString("0.00"))
        lblDisplay.Text = "Customer Status: " & status & vbCrLf &
                        "Quantity: " & quantity.ToString() & vbCrLf &
                        "Price per unit: $" & pricePerUnit.ToString("0.00") & vbCrLf &
                        "Total Price: $" & totalPrice.ToString("0.00")

    End Function
End Class