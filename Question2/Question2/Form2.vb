Public Class Rent
    Dim luxuryCoupon As Boolean
    Dim rentalFee As Double
    Dim additionalCharge As Double
    Private Sub btnLuxury_Click(sender As Object, e As EventArgs) Handles btnLuxury.Click
        Dim result As DialogResult = MessageBox.Show("Do you have a luxury coupon?", "Coupon", MessageBoxButtons.YesNo)

        ' Set luxuryCoupon based on user's response
        If result = DialogResult.Yes Then
            luxuryCoupon = True
        Else
            luxuryCoupon = False
        End If

        calculateRent()
    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        rentalFee = 55
        MsgBox("The total rental fee is: $" & rentalFee)
    End Sub

    Private Sub calculateRent()
        If luxuryCoupon Then
            additionalCharge = 10
        Else
            additionalCharge = 30
        End If

        rentalFee = 55 + additionalCharge

        MsgBox("The total rental fee is: $" & rentalFee)

    End Sub

    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class