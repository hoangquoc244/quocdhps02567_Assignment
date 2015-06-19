<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyKhachHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbThongTinKH = New System.Windows.Forms.GroupBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.dtgKhachhang = New System.Windows.Forms.DataGridView()
        Me.grbThongTinKH.SuspendLayout()
        CType(Me.dtgKhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbThongTinKH
        '
        Me.grbThongTinKH.Controls.Add(Me.btnTim)
        Me.grbThongTinKH.Controls.Add(Me.btnXoa)
        Me.grbThongTinKH.Controls.Add(Me.btnSua)
        Me.grbThongTinKH.Controls.Add(Me.btnThem)
        Me.grbThongTinKH.Controls.Add(Me.txtDiachi)
        Me.grbThongTinKH.Controls.Add(Me.txtSDT)
        Me.grbThongTinKH.Controls.Add(Me.txtTenKH)
        Me.grbThongTinKH.Controls.Add(Me.txtMaKH)
        Me.grbThongTinKH.Controls.Add(Me.lblDiachi)
        Me.grbThongTinKH.Controls.Add(Me.lblSDT)
        Me.grbThongTinKH.Controls.Add(Me.lblMaKH)
        Me.grbThongTinKH.Controls.Add(Me.lblTenKH)
        Me.grbThongTinKH.Location = New System.Drawing.Point(12, 12)
        Me.grbThongTinKH.Name = "grbThongTinKH"
        Me.grbThongTinKH.Size = New System.Drawing.Size(331, 163)
        Me.grbThongTinKH.TabIndex = 0
        Me.grbThongTinKH.TabStop = False
        Me.grbThongTinKH.Text = "Nhập thông tin khách hàng"
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(252, 133)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(75, 23)
        Me.btnTim.TabIndex = 2
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(171, 133)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(90, 133)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 2
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(9, 133)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(123, 107)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(187, 20)
        Me.txtDiachi.TabIndex = 1
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(123, 79)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(187, 20)
        Me.txtSDT.TabIndex = 1
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(123, 49)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(187, 20)
        Me.txtTenKH.TabIndex = 1
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(123, 19)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(187, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Location = New System.Drawing.Point(6, 114)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(43, 13)
        Me.lblDiachi.TabIndex = 0
        Me.lblDiachi.Text = "Địa chỉ:"
        '
        'lblSDT
        '
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Location = New System.Drawing.Point(6, 86)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(73, 13)
        Me.lblSDT.TabIndex = 0
        Me.lblSDT.Text = "Số điện thoại:"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(6, 26)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(85, 13)
        Me.lblMaKH.TabIndex = 0
        Me.lblMaKH.Text = "Mã khách hàng:"
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Location = New System.Drawing.Point(6, 56)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(102, 13)
        Me.lblTenKH.TabIndex = 0
        Me.lblTenKH.Text = "Họ tên khách hàng:"
        '
        'dtgKhachhang
        '
        Me.dtgKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgKhachhang.Location = New System.Drawing.Point(349, 15)
        Me.dtgKhachhang.Name = "dtgKhachhang"
        Me.dtgKhachhang.Size = New System.Drawing.Size(535, 160)
        Me.dtgKhachhang.TabIndex = 1
        '
        'frmQuanLyKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 186)
        Me.Controls.Add(Me.dtgKhachhang)
        Me.Controls.Add(Me.grbThongTinKH)
        Me.Name = "frmQuanLyKhachHang"
        Me.Text = "Quản Lý Khách Hàng"
        Me.grbThongTinKH.ResumeLayout(False)
        Me.grbThongTinKH.PerformLayout()
        CType(Me.dtgKhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbThongTinKH As System.Windows.Forms.GroupBox
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents lblSDT As System.Windows.Forms.Label
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents lblTenKH As System.Windows.Forms.Label
    Friend WithEvents dtgKhachhang As System.Windows.Forms.DataGridView
End Class
