Public Class loginForm
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = "admin"
        Dim password As String = "admin"

        If (txt_pass.Text = password Or txt_username.Text = username) Then
            MessageBox.Show("Log-in Successful", "Log-in Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form As New Form1
            form.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Username or Password", "Log-in Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the program?", "Close Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If result = DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class