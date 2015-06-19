Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLyKhachHang
    Dim database As New DataTable
    Dim chuoiconnect As String = "workstation id=quocdhps02567.mssql.somee.com;packet size=4096;user id=quocdhps02567_SQLLogin_1;pwd=7nlx7l1pxq;data source=quocdhps02567.mssql.somee.com;persist security info=False;initial catalog=quocdhps02567"

    Private Sub frmQuanLyKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        connect.Open()
        query1.Fill(database)
        dtgKhachhang.DataSource = database.DefaultView
    End Sub

    Private Sub dtgKhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgKhachhang.CellContentClick
        Dim index As Integer = dtgKhachhang.CurrentCell.RowIndex
        txtMaKH.Text = dtgKhachhang.Item(0, index).Value
        txtTenKH.Text = dtgKhachhang.Item(1, index).Value
        txtSDT.Text = dtgKhachhang.Item(2, index).Value
        txtDiachi.Text = dtgKhachhang.Item(3, index).Value
    End Sub
   
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim query2 As String = "insert into KhachHang values (@MaKH,@TenKH,@SDT,@DiaChi)"
        Dim Executequery1 As New SqlCommand(query2, connect)
        connect.Open()

        Try
            Executequery1.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            Executequery1.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            Executequery1.Parameters.AddWithValue("@SDT", txtSDT.Text)
            Executequery1.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            MessageBox.Show("Thêm dữ liệu thành công!")
            Executequery1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thêm được dữ liệu!")
        End Try
        Dim query3 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        database.Clear()

        query3.Fill(database)
        dtgKhachhang.DataSource = database.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi1 As New SqlConnection(chuoiconnect)
        ketnoi1.Open()
        Dim Stradd1 As String = "Update KhachHang set TenKH=@TenKH,SDT=@SDT,DiaChi=@DiaChi where MaKH=@MaKH"
        Dim com As New SqlCommand(Stradd1, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            com.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            com.Parameters.AddWithValue("@SDT", txtSDT.Text)
            com.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show("Sửa dữ liệu thành công!")
        Catch ex As Exception
            MessageBox.Show("Sửa dữ liệu không thành công!")
        End Try
        database.Clear()
        dtgKhachhang.DataSource = database
        dtgKhachhang.DataSource = Nothing
        Loaddata()
    End Sub
    Private Sub Loaddata()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)

        connect.Open()
        query1.Fill(database)
        dtgKhachhang.DataSource = database.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from KhachHang where MaKH=@MaKH"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xóa không thành công!")
        End Try
        database.Clear()
        dtgKhachhang.DataSource = database
        dtgKhachhang.DataSource = Nothing
        Loaddata()
    End Sub
End Class