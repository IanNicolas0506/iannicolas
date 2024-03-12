Public Class Form1
    Private Sub txt_math_TextChanged(sender As Object, e As EventArgs) Handles txt_math.TextChanged

    End Sub

    Private Sub txt_englsih_TextChanged(sender As Object, e As EventArgs) Handles txt_english.TextChanged

    End Sub

    Private Sub txt_science_TextChanged(sender As Object, e As EventArgs) Handles txt_science.TextChanged

    End Sub

    Private Sub txt_pe_TextChanged(sender As Object, e As EventArgs) Handles txt_pe.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Evaluate.Click
        Dim num1 As Double = txt_math.Text
        Dim num2 As Double = txt_english.Text
        Dim num3 As Double = txt_science.Text
        Dim num4 As Double = txt_pe.Text
        Dim average As Double = (num1 + num2 + num3 + num4) / 4
        i As integer
        If average >= 90 AndAlso average <= 100 Then
            For i = 1 To 5
                MessageBox.Show("A+")
            Next
        ElseIf average >= 80 AndAlso average <= 89 Then
            For i = 1 To 3
                MessageBox.Show("B+")
            Next
        ElseIf average >= 75 AndAlso average <= 79 Then
            For i = 1 To 2
                MessageBox.Show("C+")
            Next
        Else
            For i = 1 To 10
                MessageBox.Show("Failed")
            Next
        End If
    End Sub
End Class
