Public Class Form1
    Dim age As Integer
    Dim underageTicket As Double
    Dim childTicket As Double
    Dim adultTicket As Double
    Dim seniorTicket As Double
    Dim internationalMovie As Boolean
    Dim totalCost As Double

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Reset total cost
        totalCost = 0

        ' Loop until user chooses to stop
        While True
            ' Ask the user for their age
            Dim inputAge As String = InputBox("Please enter your age", "User age", "Enter your age: ")
            Dim age As Integer
            Integer.TryParse(inputAge, age)

            ' Ask if they purchased an international movie ticket
            Dim result As DialogResult = MessageBox.Show("Did you purchase an international movie ticket?", "Ticket Type", MessageBoxButtons.YesNo)

            ' Calculate total cost based on user's input
            totalCost += CalculateTotalCost(age, result = DialogResult.Yes)

            ' Ask if user wants to continue
            Dim continueLoop As DialogResult = MessageBox.Show("Do you want to add another customer?", "Continue", MessageBoxButtons.YesNo)
            If continueLoop = DialogResult.No Then
                Exit While ' Exit loop if user chooses to stop
            End If
        End While

        ' Display total cost
        MessageBox.Show("Total cost for all customers: $" & totalCost)
    End Sub

    Private Function CalculateTotalCost(age, internationalMovie) As Double
        Dim cost As Double
        Dim childPrice As Double = 8
        Dim adultPrice As Double = 12
        Dim seniorPrice As Double = 12 / 2 ' Senior citizens are charged half-price
        Dim international As Double = 1.2 ' 20% extra for international movies
        If age < 4 Then
            cost = 0
        ElseIf age >= 4 And age <= 12 Then
            cost = childPrice
        ElseIf age > 12 And age <= 50 Then
            cost = adultPrice
        ElseIf age > 50 And age <= 120 Then
            cost = seniorPrice
        Else
            MessageBox.Show("Invalid age. Ticket cannot be calculated.")
            Return 0
        End If

        ' Apply extra charge for international movies if applicable
        If internationalMovie Then
            cost *= international
        End If


        Return cost
    End Function
End Class
