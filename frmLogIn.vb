Public Class frmLogIn
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim Id As String
        Dim Pw As String

        Id = txtLogIn.Text
        Pw = txtPass.Text

        If Id = "quocdhps02567" Then
            If Pw = "123456" Then
                MessageBox.Show("Đăng Nhập Thành Công!")
                DangnhapID = Id
                MatkhauPW = Pw
                frmMain.ShowDialog()
            Else
                MessageBox.Show("Sai Mật Khẩu!")
                txtLogIn.Focus()
            End If
        Else
            MessageBox.Show("Sai tên đăng nhập!")
        End If
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
    Private Sub txtLogIn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLogIn.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtLogIn.Focus()
        End If
    End Sub
    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnLogIn_Click(sender, e)
        End If
    End Sub
End Class
