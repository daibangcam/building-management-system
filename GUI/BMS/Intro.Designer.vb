<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intro))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_guest = New System.Windows.Forms.Button()
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.img_logo_smarthome = New System.Windows.Forms.PictureBox()
        Me.img_logo_HUFI = New System.Windows.Forms.PictureBox()
        CType(Me.img_logo_smarthome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_logo_HUFI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Location = New System.Drawing.Point(243, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(308, 57)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "GVHD: Th.S NGUYỄN THỊ THANH TRÚC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SVTH : TRẦN THỊ CẨM THU " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MSSV: 2002160324" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(56, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(448, 72)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "HỆ THỐNG VẬN HÀNH " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VÀ QUẢN LÝ TOÀ NHÀ BMS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(155, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 22)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "KHOÁ LUẬN TỐT NGHIỆP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(110, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 22)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "KHOA CÔNG NGHỆ ĐIỆN - ĐIỆN TỬ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "TRƯỜNG ĐẠI HỌC CÔNG NGHIỆP THỰC PHẨM TP. HCM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(278, 386)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(92, 38)
        Me.btn_login.TabIndex = 34
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_guest
        '
        Me.btn_guest.Location = New System.Drawing.Point(423, 385)
        Me.btn_guest.Name = "btn_guest"
        Me.btn_guest.Size = New System.Drawing.Size(92, 38)
        Me.btn_guest.TabIndex = 34
        Me.btn_guest.Text = "Guest"
        Me.btn_guest.UseVisualStyleBackColor = True
        '
        'txtbox_user
        '
        Me.txtbox_user.Location = New System.Drawing.Point(365, 316)
        Me.txtbox_user.Multiline = True
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(150, 21)
        Me.txtbox_user.TabIndex = 35
        Me.txtbox_user.Text = "admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(274, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(274, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 19)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Password"
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(365, 349)
        Me.txtbox_pass.Multiline = True
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pass.Size = New System.Drawing.Size(150, 21)
        Me.txtbox_pass.TabIndex = 35
        Me.txtbox_pass.Text = "admin"
        '
        'img_logo_smarthome
        '
        Me.img_logo_smarthome.Image = Global.BMS.My.Resources.Resources.smarthome
        Me.img_logo_smarthome.InitialImage = Global.BMS.My.Resources.Resources.smarthome
        Me.img_logo_smarthome.Location = New System.Drawing.Point(14, 243)
        Me.img_logo_smarthome.Name = "img_logo_smarthome"
        Me.img_logo_smarthome.Size = New System.Drawing.Size(223, 180)
        Me.img_logo_smarthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo_smarthome.TabIndex = 33
        Me.img_logo_smarthome.TabStop = False
        '
        'img_logo_HUFI
        '
        Me.img_logo_HUFI.Image = Global.BMS.My.Resources.Resources.logo
        Me.img_logo_HUFI.InitialImage = Global.BMS.My.Resources.Resources.logo
        Me.img_logo_HUFI.Location = New System.Drawing.Point(250, 56)
        Me.img_logo_HUFI.Name = "img_logo_HUFI"
        Me.img_logo_HUFI.Size = New System.Drawing.Size(60, 60)
        Me.img_logo_HUFI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo_HUFI.TabIndex = 32
        Me.img_logo_HUFI.TabStop = False
        '
        'Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 436)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_user)
        Me.Controls.Add(Me.btn_guest)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.img_logo_smarthome)
        Me.Controls.Add(Me.img_logo_HUFI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Intro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Building Management System - Tran Thi Cam Thu"
        CType(Me.img_logo_smarthome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_logo_HUFI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img_logo_HUFI As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents img_logo_smarthome As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_guest As Button
    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbox_pass As TextBox
End Class
