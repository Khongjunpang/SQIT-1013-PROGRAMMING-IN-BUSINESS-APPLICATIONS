Public Class Form1
    Dim member As Boolean
    Dim dayOfWeek As String
    Dim greenFee As Double

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        member = True
        CalGreenFee()
    End Sub

    Private Sub btnNonMember_Click(sender As Object, e As EventArgs) Handles btnNonMember.Click
        member = False
        CalGreenFee()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dayOfWeek = WeekdayName(Weekday(Today()))

    End Sub

    Private Sub CalGreenFee()
        If member Then
            greenFee = 100
        Else
            Select Case dayOfWeek
                Case "Monday", "Tuesday", "Wednesday", "Thursday"
                    greenFee = 150
                    MsgBox("Today is working days")
                Case "Friday", "Saturday", "Sunday"
                    greenFee = 200
                    MsgBox("Today is weekend")

            End Select
        End If
        MsgBox("The green fee for " & dayOfWeek & " is: $" & greenFee)

    End Sub
End Class
