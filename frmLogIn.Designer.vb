<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Me.txtLogIn = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLogIn
        '
        Me.txtLogIn.Location = New System.Drawing.Point(125, 67)
        Me.txtLogIn.Name = "txtLogIn"
        Me.txtLogIn.Size = New System.Drawing.Size(100, 20)
        Me.txtLogIn.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(125, 99)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 2
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.Location = New System.Drawing.Point(12, 74)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(84, 13)
        Me.lblLogIn.TabIndex = 3
        Me.lblLogIn.Text = "Tên đăng nhập:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(12, 106)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(55, 13)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Mật khẩu:"
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(64, 30)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(120, 25)
        Me.lblTittle.TabIndex = 4
        Me.lblTittle.Text = "Đăng Nhập"
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(69, 135)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 5
        Me.btnLogIn.Text = "Đăng Nhập"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(150, 135)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Thoát"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.quocdhps02567_Assignment.My.Resources.Resources._img_resize__5_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(369, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblLogIn)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtLogIn)
        Me.Name = "frmLogIn"
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogIn As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblLogIn As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblTittle As System.Windows.Forms.Label
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
