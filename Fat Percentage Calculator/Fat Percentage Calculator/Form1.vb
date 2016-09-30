Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCalories.Clear()
        txtFat.Clear()
        lblResult.Text = ("")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim fat, cal, calFromFat, percentCalFromFat As Double
        ' Dim testString As String = FormatPercent(percentCalFromFat)

        ' Convert variables
        fat = CDbl(txtFat.Text)
        cal = CDbl(txtCalories.Text)

        calFromFat = (fat * 9)

        percentCalFromFat = calFromFat / cal
        lblResult.Text = percentCalFromFat.ToString("P")

    End Sub
End Class
