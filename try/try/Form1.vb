Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim age As Integer = 20
        'Select Case True
        '    Case age < 12
        '        MessageBox.Show("young")
        '    Case age >= 12 AndAlso age < 18
        '        MessageBox.Show("teen")
        '    Case age >= 18 AndAlso age < 30
        '        MessageBox.Show("adult")
        '    Case age >= 30
        '        MessageBox.Show("elder")
        'End Select

        'Dim a As Integer = 0
        'Do
        '    MessageBox.Show("Hello World", a.ToString)
        '    a += 1
        'Loop While (a <= 20)


        'For c As Byte = 1 To 20
        '    MessageBox.Show("Hello World Number ", c.ToString)
        'Next

        'Dim z As Integer = 0
        'While z <= 20
        '    MessageBox.Show("counting {0}", z.ToString)
        '    z += 1
        'End While


        'Dim FirstName, LastName As String
        'FirstName = "Ian"
        'LastName = "Nicolas"
        'MessageBox.Show(FirstName + " " + LastName)

        'Dim sarray() As String = {"Hello", "to", "the", "World", "!"}
        'Dim message As String = String.Join("-", sarray(0) + sarray(1))
        'MessageBox.Show("Message: " + sarray(0))

        'Dim str1, str2 As String
        'str1 = " Mekus"
        'str2 = "Mekus"
        'If (String.Compare(str1, str2) = 0) Then
        '    MsgBox(str1 + " " + str2 + " mo na yan ng mabilis!")
        'Else
        '    MsgBox(str1 + " " + str2 + " mo na yan insan!")

        'End If




        'Dim intData() As Integer = {1, 5, 19, 7, 9, 11}
        'Dim StrArray() As String = {"John", "Matt", "Sun", "Rap", "Ariel", "Ai"}

        'For Each value As String In StrArray
        '    MsgBox(value.ToString)


        'Next
        'MsgBox(StrArray(0).ToString())
        'MsgBox(StrArray(1).ToString())
        'MsgBox(StrArray(2).ToString())
        'MsgBox(StrArray(3).ToString())
        'StrArray(0) = "Ian"
        'MsgBox(StrArray(0).ToString())

        Dim colors() As String = {"Blue", "Red", "Green", "Yellow", "White"}
        Array.Sort(colors)
        For Each count As String In colors
            MsgBox(count.ToString)
        Next

        Array.Reverse(colors)
        For Each count As String In colors
            MsgBox(count.ToString)
        Next



    End Sub
End Class
