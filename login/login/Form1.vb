Imports System.Security.Cryptography

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        Password = TextBox2.Text
        If (username.Equals("aira") And password.Equals("hello")) Then
            Me.Hide()
            Form2.Show()

            MessageBox.Show("login success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("wrong username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "hello" Then
            TextBox2.PasswordChar = "●"
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

End Class
