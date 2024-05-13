Public Class Form1
    Dim purchaseAmount As Double
    Dim shippingCode As String

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim sales As String = InputBox("Enter the total amount of order:", "Total amount", "Please enter the amount")
        Double.TryParse(sales, purchaseAmount)

        If purchaseAmount <= 0 Then
            MsgBox("Invalid Input. Please enter a valid number greater than 0.")
            Me.Close()
        ElseIf purchaseAmount > 100 Then
            shippingCode = InputBox("Please enter the shipping code:", "Shipping Code", "Enter the shipping code")
            If shippingCode = "SELFIEYA" Then
                MsgBox("The customer will have free shipping.")
            Else
                MsgBox("The customer required to pay shipping fee.")
            End If
        Else
            MsgBox("The customer required to pay shipping fee.")
        End If


    End Sub


End Class
