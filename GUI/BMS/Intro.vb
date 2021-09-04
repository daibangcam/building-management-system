Public Class Intro
    ' khi nhấn button Login thì sẽ thực hiện hàm này
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If String.IsNullOrEmpty(txtbox_user.Text) Then
            'nếu ko có nhập username thì báo lỗi
            MessageBox.Show("Please input Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtbox_pass.Text) Then
            'nếu ko có nhập pass thì báo lỗi
            MessageBox.Show("Please input Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'nếu user và pass đúng
            'để thay đổi user và pass thì sửa ở dòng dưới, chỗ 2 chữ "admin", cái đầu là user, cái sau là pass
            If txtbox_pass.Text = "admin" And txtbox_pass.Text = "admin" Then
                ' khai báo form cpanel_admin
                Dim f As New Cpanel_admin
                ' vô hiệu (ẩn) đi form khởi động này
                Me.Visible = False
                ' mở form cpanel_admin lên
                f.ShowDialog()
                ' kích hoạt form cpanel_admin
                Me.Visible = True
            Else
                'nếu user và pass ko đúng thì báo lỗi
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    ' khi nhấn button GUEST thì sẽ thực hiện hàm này
    Private Sub btn_guest_Click(sender As Object, e As EventArgs) Handles btn_guest.Click
        ' khai báo form cpanel_guest
        Dim f As New Cpanel_guest
        ' vô hiệu (ẩn) đi form khởi động này
        Me.Visible = False
        ' mở form cpanel_guest
        f.ShowDialog()
        ' kích hoạt form cpanel_guest
        Me.Visible = True
    End Sub
End Class