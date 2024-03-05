Public Class Form1
    Function HelloUser(ByVal UserName As String) As String
        Return "Konichiwa " + UserName + "!"
    End Function
    Function factorial(ByVal num As Double) As Double
        'Dim result As Double
        If (num = 1) Then
            Return 1
        Else
            'result = factorial(num - 1) * num
            'Return result
            Return factorial(num - 1) * num
        End If
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(HelloUser("IanNicolas").ToString)
        MsgBox(factorial(2).ToString)

    End Sub

End Class
