Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer = 10
        Do
            MessageBox.Show("counting: {0}" & a.ToString)
            a += 1
        Loop While (a < 20)
    End Sub
End Class