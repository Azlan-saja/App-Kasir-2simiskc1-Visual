Public Class Form_login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user1 As String = "Ananda Pratiwi"
        Dim pass1 As String = "Nanda99!"
        Dim user2 As String = "azlan"
        Dim pass2 As String = "123456"

        If (txtUser.Text = user1 And txtPass.Text = pass1) OrElse (txtUser.Text = user2 And txtPass.Text = pass2) Then
            Login.User_Aktif = txtUser.Text
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Data yang Anda masukkan salah. Silakan cek username dan password.", MsgBoxStyle.Critical, "Peringatan")
            txtUser.Clear()
            txtPass.Clear()
            txtUser.Focus()
        End If

    End Sub
End Class