Public Class sercurity
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_verify.Click
        If String.IsNullOrEmpty(txtbox_user.Text) Then
            MessageBox.Show("Please input Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtbox_pass.Text) Then
            MessageBox.Show("Please input Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtbox_pass.Text = "admin" And txtbox_pass.Text = "admin" Then
                Me.Close()
            Else
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class