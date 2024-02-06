Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles login_btn.MouseHover
        login_btn.BackColor = Color.DarkGray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim username As String = username_txt.Text
        Dim password As String = password_txt.Text
        If Not String.IsNullOrEmpty(username_txt.Text) And Not String.IsNullOrEmpty(password_txt.Text) Then
            If username = "Admin" And password = "1234" Then
                MsgBox("Hello " + username.ToString(), vbInformation, "WELCOME!")
                username_txt.Text = ""
                password_txt.Text = ""
                username_txt.Focus()
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("Your input username or password was invalid!", vbCritical, "Invalid User!")
                username_txt.Text = ""
                password_txt.Text = ""

            End If
        Else

            MsgBox("You don't have input any character!", vbCritical, "Invalid User!")

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles register_btn.MouseHover
        register_btn.BackColor = Color.DarkGray
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs)
        register_btn.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave_1(sender As Object, e As EventArgs) Handles login_btn.MouseLeave
        login_btn.BackColor = Color.Black
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged

    End Sub

    Private Sub register_btn_MouseLeave(sender As Object, e As EventArgs) Handles register_btn.MouseLeave
        register_btn.BackColor = Color.Black
    End Sub

    Private Sub username_txt_TextChanged(sender As Object, e As EventArgs) Handles username_txt.TextChanged

    End Sub

    Private Sub username_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles username_txt.KeyUp
        If e.KeyCode = Keys.Enter Then
            password_txt.Focus()
        End If
    End Sub

    Private Sub password_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles password_txt.KeyUp
        If e.KeyCode = Keys.Enter Then
            login_btn.PerformClick()
        End If
    End Sub
End Class
