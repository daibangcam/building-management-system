<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cpanel_admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cpanel_admin))
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tab_connect = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtbox_th_CO = New System.Windows.Forms.TextBox()
        Me.txtbox_th_smoke = New System.Windows.Forms.TextBox()
        Me.txtbox_th_humid = New System.Windows.Forms.TextBox()
        Me.txtbox_th_temp = New System.Windows.Forms.TextBox()
        Me.btn_default = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cbbox_port = New System.Windows.Forms.ComboBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.cbbox_baud = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_disconnect = New System.Windows.Forms.Button()
        Me.tab_cpanel = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtbox_device = New System.Windows.Forms.TextBox()
        Me.txtbox_co = New System.Windows.Forms.TextBox()
        Me.txtbox_smoke = New System.Windows.Forms.TextBox()
        Me.txtbox_doam = New System.Windows.Forms.TextBox()
        Me.txtbox_nhietdo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.img_alarm_humid = New System.Windows.Forms.PictureBox()
        Me.img_alarm_temp = New System.Windows.Forms.PictureBox()
        Me.img_alarm_smoke = New System.Windows.Forms.PictureBox()
        Me.img_alarm_CO = New System.Windows.Forms.PictureBox()
        Me.img_alarm = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.img_emergency = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.img_led_3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.img_led_2 = New System.Windows.Forms.PictureBox()
        Me.img_fan_2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.img_led_1 = New System.Windows.Forms.PictureBox()
        Me.img_fan_1 = New System.Windows.Forms.PictureBox()
        Me.tab_log = New System.Windows.Forms.TabPage()
        Me.txtbox_log = New System.Windows.Forms.TextBox()
        Me.tab_about = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.img_logo_smarthome = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.tab.SuspendLayout()
        Me.tab_connect.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.tab_cpanel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.img_alarm_humid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_alarm_temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_alarm_smoke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_alarm_CO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_alarm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.img_emergency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.img_led_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.img_led_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_fan_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.img_led_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_fan_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_log.SuspendLayout()
        Me.tab_about.SuspendLayout()
        CType(Me.img_logo_smarthome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Controls.Add(Me.tab_connect)
        Me.tab.Controls.Add(Me.tab_cpanel)
        Me.tab.Controls.Add(Me.tab_log)
        Me.tab.Controls.Add(Me.tab_about)
        Me.tab.Location = New System.Drawing.Point(2, 2)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(385, 337)
        Me.tab.TabIndex = 0
        '
        'tab_connect
        '
        Me.tab_connect.BackColor = System.Drawing.SystemColors.Menu
        Me.tab_connect.Controls.Add(Me.GroupBox8)
        Me.tab_connect.Controls.Add(Me.GroupBox7)
        Me.tab_connect.Location = New System.Drawing.Point(4, 22)
        Me.tab_connect.Name = "tab_connect"
        Me.tab_connect.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_connect.Size = New System.Drawing.Size(377, 311)
        Me.tab_connect.TabIndex = 0
        Me.tab_connect.Text = "General"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtbox_th_CO)
        Me.GroupBox8.Controls.Add(Me.txtbox_th_smoke)
        Me.GroupBox8.Controls.Add(Me.txtbox_th_humid)
        Me.GroupBox8.Controls.Add(Me.txtbox_th_temp)
        Me.GroupBox8.Controls.Add(Me.btn_default)
        Me.GroupBox8.Controls.Add(Me.btn_reset)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 150)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(365, 154)
        Me.GroupBox8.TabIndex = 49
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Alarm Parameters"
        '
        'txtbox_th_CO
        '
        Me.txtbox_th_CO.Location = New System.Drawing.Point(270, 72)
        Me.txtbox_th_CO.Name = "txtbox_th_CO"
        Me.txtbox_th_CO.Size = New System.Drawing.Size(45, 23)
        Me.txtbox_th_CO.TabIndex = 61
        Me.txtbox_th_CO.Text = "456"
        Me.txtbox_th_CO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_th_smoke
        '
        Me.txtbox_th_smoke.Location = New System.Drawing.Point(270, 34)
        Me.txtbox_th_smoke.Name = "txtbox_th_smoke"
        Me.txtbox_th_smoke.Size = New System.Drawing.Size(45, 23)
        Me.txtbox_th_smoke.TabIndex = 62
        Me.txtbox_th_smoke.Text = "123"
        Me.txtbox_th_smoke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_th_humid
        '
        Me.txtbox_th_humid.Location = New System.Drawing.Point(106, 71)
        Me.txtbox_th_humid.Name = "txtbox_th_humid"
        Me.txtbox_th_humid.Size = New System.Drawing.Size(45, 23)
        Me.txtbox_th_humid.TabIndex = 63
        Me.txtbox_th_humid.Text = "65"
        Me.txtbox_th_humid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_th_temp
        '
        Me.txtbox_th_temp.Location = New System.Drawing.Point(106, 34)
        Me.txtbox_th_temp.Name = "txtbox_th_temp"
        Me.txtbox_th_temp.Size = New System.Drawing.Size(45, 23)
        Me.txtbox_th_temp.TabIndex = 64
        Me.txtbox_th_temp.Text = "35"
        Me.txtbox_th_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_default
        '
        Me.btn_default.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_default.Location = New System.Drawing.Point(240, 113)
        Me.btn_default.Name = "btn_default"
        Me.btn_default.Size = New System.Drawing.Size(75, 23)
        Me.btn_default.TabIndex = 0
        Me.btn_default.Text = "Default"
        Me.btn_default.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_reset.Location = New System.Drawing.Point(105, 113)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 0
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(211, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "CO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(211, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Smoke"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(8, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Humidity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(8, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Temperature"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cbbox_port)
        Me.GroupBox7.Controls.Add(Me.btn_connect)
        Me.GroupBox7.Controls.Add(Me.cbbox_baud)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.btn_scan)
        Me.GroupBox7.Controls.Add(Me.btn_disconnect)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(365, 138)
        Me.GroupBox7.TabIndex = 49
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Connect"
        '
        'cbbox_port
        '
        Me.cbbox_port.FormattingEnabled = True
        Me.cbbox_port.Location = New System.Drawing.Point(105, 31)
        Me.cbbox_port.Name = "cbbox_port"
        Me.cbbox_port.Size = New System.Drawing.Size(121, 24)
        Me.cbbox_port.TabIndex = 1
        '
        'btn_connect
        '
        Me.btn_connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_connect.Location = New System.Drawing.Point(11, 103)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(75, 23)
        Me.btn_connect.TabIndex = 0
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'cbbox_baud
        '
        Me.cbbox_baud.FormattingEnabled = True
        Me.cbbox_baud.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.cbbox_baud.Location = New System.Drawing.Point(105, 70)
        Me.cbbox_baud.Name = "cbbox_baud"
        Me.cbbox_baud.Size = New System.Drawing.Size(121, 24)
        Me.cbbox_baud.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baudrate"
        '
        'btn_scan
        '
        Me.btn_scan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_scan.Location = New System.Drawing.Point(11, 31)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(75, 23)
        Me.btn_scan.TabIndex = 0
        Me.btn_scan.Text = "Scan Port"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'btn_disconnect
        '
        Me.btn_disconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_disconnect.Location = New System.Drawing.Point(11, 104)
        Me.btn_disconnect.Name = "btn_disconnect"
        Me.btn_disconnect.Size = New System.Drawing.Size(75, 23)
        Me.btn_disconnect.TabIndex = 0
        Me.btn_disconnect.Text = "Disconnect"
        Me.btn_disconnect.UseVisualStyleBackColor = True
        '
        'tab_cpanel
        '
        Me.tab_cpanel.BackColor = System.Drawing.SystemColors.Menu
        Me.tab_cpanel.Controls.Add(Me.GroupBox4)
        Me.tab_cpanel.Controls.Add(Me.GroupBox6)
        Me.tab_cpanel.Controls.Add(Me.GroupBox5)
        Me.tab_cpanel.Controls.Add(Me.GroupBox3)
        Me.tab_cpanel.Controls.Add(Me.GroupBox2)
        Me.tab_cpanel.Controls.Add(Me.GroupBox1)
        Me.tab_cpanel.Location = New System.Drawing.Point(4, 22)
        Me.tab_cpanel.Name = "tab_cpanel"
        Me.tab_cpanel.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_cpanel.Size = New System.Drawing.Size(377, 311)
        Me.tab_cpanel.TabIndex = 1
        Me.tab_cpanel.Text = "Control"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtbox_device)
        Me.GroupBox4.Controls.Add(Me.txtbox_co)
        Me.GroupBox4.Controls.Add(Me.txtbox_smoke)
        Me.GroupBox4.Controls.Add(Me.txtbox_doam)
        Me.GroupBox4.Controls.Add(Me.txtbox_nhietdo)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(209, 213)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status"
        '
        'txtbox_device
        '
        Me.txtbox_device.Location = New System.Drawing.Point(69, 33)
        Me.txtbox_device.Name = "txtbox_device"
        Me.txtbox_device.Size = New System.Drawing.Size(122, 23)
        Me.txtbox_device.TabIndex = 48
        Me.txtbox_device.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_co
        '
        Me.txtbox_co.Location = New System.Drawing.Point(110, 179)
        Me.txtbox_co.Name = "txtbox_co"
        Me.txtbox_co.Size = New System.Drawing.Size(81, 23)
        Me.txtbox_co.TabIndex = 48
        Me.txtbox_co.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_smoke
        '
        Me.txtbox_smoke.Location = New System.Drawing.Point(110, 143)
        Me.txtbox_smoke.Name = "txtbox_smoke"
        Me.txtbox_smoke.Size = New System.Drawing.Size(81, 23)
        Me.txtbox_smoke.TabIndex = 48
        Me.txtbox_smoke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_doam
        '
        Me.txtbox_doam.Location = New System.Drawing.Point(110, 106)
        Me.txtbox_doam.Name = "txtbox_doam"
        Me.txtbox_doam.Size = New System.Drawing.Size(81, 23)
        Me.txtbox_doam.TabIndex = 48
        Me.txtbox_doam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_nhietdo
        '
        Me.txtbox_nhietdo.Location = New System.Drawing.Point(110, 69)
        Me.txtbox_nhietdo.Name = "txtbox_nhietdo"
        Me.txtbox_nhietdo.Size = New System.Drawing.Size(81, 23)
        Me.txtbox_nhietdo.TabIndex = 48
        Me.txtbox_nhietdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "CO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Device"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Smoke"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Humidity"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(12, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Temperature"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.img_alarm_humid)
        Me.GroupBox6.Controls.Add(Me.img_alarm_temp)
        Me.GroupBox6.Controls.Add(Me.img_alarm_smoke)
        Me.GroupBox6.Controls.Add(Me.img_alarm_CO)
        Me.GroupBox6.Controls.Add(Me.img_alarm)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(221, 188)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(150, 118)
        Me.GroupBox6.TabIndex = 51
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Alarm"
        '
        'img_alarm_humid
        '
        Me.img_alarm_humid.Location = New System.Drawing.Point(114, 79)
        Me.img_alarm_humid.Name = "img_alarm_humid"
        Me.img_alarm_humid.Size = New System.Drawing.Size(30, 30)
        Me.img_alarm_humid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_alarm_humid.TabIndex = 26
        Me.img_alarm_humid.TabStop = False
        '
        'img_alarm_temp
        '
        Me.img_alarm_temp.Location = New System.Drawing.Point(78, 79)
        Me.img_alarm_temp.Name = "img_alarm_temp"
        Me.img_alarm_temp.Size = New System.Drawing.Size(30, 30)
        Me.img_alarm_temp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_alarm_temp.TabIndex = 26
        Me.img_alarm_temp.TabStop = False
        '
        'img_alarm_smoke
        '
        Me.img_alarm_smoke.Location = New System.Drawing.Point(42, 79)
        Me.img_alarm_smoke.Name = "img_alarm_smoke"
        Me.img_alarm_smoke.Size = New System.Drawing.Size(30, 30)
        Me.img_alarm_smoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_alarm_smoke.TabIndex = 26
        Me.img_alarm_smoke.TabStop = False
        '
        'img_alarm_CO
        '
        Me.img_alarm_CO.Location = New System.Drawing.Point(6, 79)
        Me.img_alarm_CO.Name = "img_alarm_CO"
        Me.img_alarm_CO.Size = New System.Drawing.Size(30, 30)
        Me.img_alarm_CO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_alarm_CO.TabIndex = 26
        Me.img_alarm_CO.TabStop = False
        '
        'img_alarm
        '
        Me.img_alarm.Location = New System.Drawing.Point(57, 26)
        Me.img_alarm.Name = "img_alarm"
        Me.img_alarm.Size = New System.Drawing.Size(40, 40)
        Me.img_alarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_alarm.TabIndex = 26
        Me.img_alarm.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.img_emergency)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(221, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(150, 92)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Emergency"
        '
        'img_emergency
        '
        Me.img_emergency.Image = Global.BMS.My.Resources.Resources.emergency
        Me.img_emergency.Location = New System.Drawing.Point(57, 33)
        Me.img_emergency.Name = "img_emergency"
        Me.img_emergency.Size = New System.Drawing.Size(40, 40)
        Me.img_emergency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_emergency.TabIndex = 52
        Me.img_emergency.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.img_led_3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(278, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(87, 78)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stair"
        '
        'img_led_3
        '
        Me.img_led_3.Image = CType(resources.GetObject("img_led_3.Image"), System.Drawing.Image)
        Me.img_led_3.Location = New System.Drawing.Point(24, 25)
        Me.img_led_3.Name = "img_led_3"
        Me.img_led_3.Size = New System.Drawing.Size(40, 40)
        Me.img_led_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_led_3.TabIndex = 42
        Me.img_led_3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.img_led_2)
        Me.GroupBox2.Controls.Add(Me.img_fan_2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(142, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 81)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2nd Floor"
        '
        'img_led_2
        '
        Me.img_led_2.Image = CType(resources.GetObject("img_led_2.Image"), System.Drawing.Image)
        Me.img_led_2.Location = New System.Drawing.Point(15, 28)
        Me.img_led_2.Name = "img_led_2"
        Me.img_led_2.Size = New System.Drawing.Size(40, 40)
        Me.img_led_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_led_2.TabIndex = 41
        Me.img_led_2.TabStop = False
        '
        'img_fan_2
        '
        Me.img_fan_2.Image = CType(resources.GetObject("img_fan_2.Image"), System.Drawing.Image)
        Me.img_fan_2.Location = New System.Drawing.Point(72, 28)
        Me.img_fan_2.Name = "img_fan_2"
        Me.img_fan_2.Size = New System.Drawing.Size(40, 40)
        Me.img_fan_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_fan_2.TabIndex = 35
        Me.img_fan_2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.img_led_1)
        Me.GroupBox1.Controls.Add(Me.img_fan_1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 81)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1st Floor"
        '
        'img_led_1
        '
        Me.img_led_1.Image = Global.BMS.My.Resources.Resources.led_off
        Me.img_led_1.InitialImage = Global.BMS.My.Resources.Resources.led_off
        Me.img_led_1.Location = New System.Drawing.Point(15, 26)
        Me.img_led_1.Name = "img_led_1"
        Me.img_led_1.Size = New System.Drawing.Size(40, 40)
        Me.img_led_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_led_1.TabIndex = 36
        Me.img_led_1.TabStop = False
        '
        'img_fan_1
        '
        Me.img_fan_1.Image = CType(resources.GetObject("img_fan_1.Image"), System.Drawing.Image)
        Me.img_fan_1.Location = New System.Drawing.Point(72, 26)
        Me.img_fan_1.Name = "img_fan_1"
        Me.img_fan_1.Size = New System.Drawing.Size(40, 40)
        Me.img_fan_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_fan_1.TabIndex = 24
        Me.img_fan_1.TabStop = False
        '
        'tab_log
        '
        Me.tab_log.BackColor = System.Drawing.SystemColors.Menu
        Me.tab_log.Controls.Add(Me.txtbox_log)
        Me.tab_log.Location = New System.Drawing.Point(4, 22)
        Me.tab_log.Name = "tab_log"
        Me.tab_log.Size = New System.Drawing.Size(377, 311)
        Me.tab_log.TabIndex = 2
        Me.tab_log.Text = "Log"
        '
        'txtbox_log
        '
        Me.txtbox_log.BackColor = System.Drawing.Color.White
        Me.txtbox_log.Location = New System.Drawing.Point(5, 4)
        Me.txtbox_log.Multiline = True
        Me.txtbox_log.Name = "txtbox_log"
        Me.txtbox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbox_log.Size = New System.Drawing.Size(369, 316)
        Me.txtbox_log.TabIndex = 0
        '
        'tab_about
        '
        Me.tab_about.BackColor = System.Drawing.SystemColors.Menu
        Me.tab_about.Controls.Add(Me.TextBox1)
        Me.tab_about.Controls.Add(Me.img_logo_smarthome)
        Me.tab_about.Location = New System.Drawing.Point(4, 22)
        Me.tab_about.Name = "tab_about"
        Me.tab_about.Size = New System.Drawing.Size(377, 311)
        Me.tab_about.TabIndex = 3
        Me.tab_about.Text = "About"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(193, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 295)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'img_logo_smarthome
        '
        Me.img_logo_smarthome.Image = Global.BMS.My.Resources.Resources.about
        Me.img_logo_smarthome.InitialImage = Global.BMS.My.Resources.Resources.smarthome
        Me.img_logo_smarthome.Location = New System.Drawing.Point(13, 15)
        Me.img_logo_smarthome.Name = "img_logo_smarthome"
        Me.img_logo_smarthome.Size = New System.Drawing.Size(165, 220)
        Me.img_logo_smarthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo_smarthome.TabIndex = 34
        Me.img_logo_smarthome.TabStop = False
        '
        'SerialPort1
        '
        '
        'Cpanel_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 342)
        Me.Controls.Add(Me.tab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cpanel_admin"
        Me.Text = "Building Management System - Admin"
        Me.tab.ResumeLayout(False)
        Me.tab_connect.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.tab_cpanel.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.img_alarm_humid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_alarm_temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_alarm_smoke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_alarm_CO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_alarm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.img_emergency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.img_led_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.img_led_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_fan_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.img_led_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_fan_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_log.ResumeLayout(False)
        Me.tab_log.PerformLayout()
        Me.tab_about.ResumeLayout(False)
        Me.tab_about.PerformLayout()
        CType(Me.img_logo_smarthome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab As TabControl
    Friend WithEvents tab_connect As TabPage
    Friend WithEvents tab_cpanel As TabPage
    Friend WithEvents tab_log As TabPage
    Friend WithEvents tab_about As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cbbox_baud As ComboBox
    Friend WithEvents cbbox_port As ComboBox
    Friend WithEvents btn_scan As Button
    Friend WithEvents btn_disconnect As Button
    Friend WithEvents btn_connect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents img_led_1 As PictureBox
    Friend WithEvents img_fan_1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents img_led_2 As PictureBox
    Friend WithEvents img_fan_2 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents img_led_3 As PictureBox
    Friend WithEvents txtbox_nhietdo As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents img_alarm As PictureBox
    Friend WithEvents img_emergency As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtbox_doam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_device As TextBox
    Friend WithEvents txtbox_co As TextBox
    Friend WithEvents txtbox_smoke As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtbox_th_CO As TextBox
    Friend WithEvents txtbox_th_smoke As TextBox
    Friend WithEvents txtbox_th_humid As TextBox
    Friend WithEvents txtbox_th_temp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents txtbox_log As TextBox
    Friend WithEvents btn_default As Button
    Friend WithEvents img_logo_smarthome As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents img_alarm_humid As PictureBox
    Friend WithEvents img_alarm_temp As PictureBox
    Friend WithEvents img_alarm_smoke As PictureBox
    Friend WithEvents img_alarm_CO As PictureBox
End Class
