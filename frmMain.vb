Public Class frmMain

    Private Sub btnCustom_Click(sender As Object, e As EventArgs)
        frmQuanLyKhachHang.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogIn.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        frmQuanLyKhachHang.ShowDialog()
    End Sub
End Class