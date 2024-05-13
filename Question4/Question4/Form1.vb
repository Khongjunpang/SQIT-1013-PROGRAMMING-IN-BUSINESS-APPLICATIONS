
Public Class Form1

    Dim input As Integer
    Dim result As Integer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        input = InputBox("Please enter your number:", "Number", "Enter a number")
        result = Factorial(input)
        MsgBox("Factorial of " & input & " is: " & result)
    End Sub

    Function Factorial(num As Integer) As Integer
        If num <= 1 Then
            Factorial = 1
        Else
            Factorial = num * Factorial(num - 1)
        End If
    End Function

End Class
