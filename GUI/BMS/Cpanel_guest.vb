Public Class Cpanel_guest
    ' khai báo biến -> báo đã mở port serial
    Private comOpen As Boolean
    ' khai báo biến -> chuỗi dữ liệu nhận từ port serial <-- arduino gửi lên
    Private readBuffer As String = String.Empty
    ' khai báo các biến báo trạng thái thiết bị đèn + quạt
    Private status_led_1 As Boolean
    Private status_fan_1 As Boolean
    Private status_led_2 As Boolean
    Private status_fan_2 As Boolean
    Private status_led_3 As Boolean
    ' khai báo các biến giá trị của các cảm biến MQ7 + MQ2 + DHT11
    Private value_MQ7 As Integer
    Private value_MQ2 As Integer
    'Private value_temperature As Integer
    'Private value_humidity As Integer
    ' khai báo các biến giá trị ngưỡng để so sánh với các giá trị đọc từ cảm biến --> kích hoạt chế độ báo động
    ' MQ7 là khí CO báo cháy
    ' MQ2 là khói
    ' DHT11 cho nhiệt độ và độ ẩm
    Private th_CO As Integer
    Private th_smoke As Integer
    'Private th_temperature As Integer
    'Private th_humidity As Integer
    ' khai báo biến ghi lại ngày giờ hiện tại để viết logger
    Dim todaysdate As String = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now)
    ' khi form cpanel_guest vừa được chạy lên thì sẽ thực hiện hàm này
    Private Sub Cpanel_guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' link vào form chính (form khởi động)
        Me.CenterToParent()
        ' vô hiệu button CONNECT và đặt phía trước
        btn_connect.Enabled = False
        btn_connect.BringToFront()
        ' vô hiệu button DISCONNECT và đặt phía sau (do 2 button CONNECT và DISCONNECT chồng lên nhau)
        btn_disconnect.Enabled = False
        btn_disconnect.SendToBack()
        ' chọn mặc định baudrate = 9600 trong combobox (nhìn trên form, ngay kế bên chữ baudrate)
        cbbox_baud.SelectedItem = "9600"
    End Sub
    ' Khi nhấn button SCAN PORT thì chạy hàm này
    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        ' xóa hết các port hiện có
        cbbox_port.Items.Clear()
        ' khai báo mảng myPort để chứa thông tin các port hiện có
        Dim myPort As Array
        ' gọi i là số nguyên
        Dim i As Integer
        ' quét tìm tất cả các port và gán vào myPort
        myPort = IO.Ports.SerialPort.GetPortNames()
        ' add vào combobox (nhìn trên form, ngay kế bên button SCAN PORT)
        cbbox_port.Items.AddRange(myPort)
        ' đếm số port có
        i = cbbox_port.Items.Count
        i = i - 1
        Try
            ' mặc định chọn port cuối cùng trong danh sách
            cbbox_port.SelectedIndex = i
        Catch ex As Exception
            ' nếu ko có port thì báo lỗi
            Dim result As DialogResult
            result = MessageBox.Show("Can not find COM Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbbox_port.Text = ""
            cbbox_port.Items.Clear()
            Call Cpanel_guest_Load(Me, e)
        End Try
        ' sau khi đã scan port thì kích hoạt button CONNECT để kết nối port
        btn_connect.Enabled = True
        btn_connect.BringToFront()
        ' cho combobox tự sổ xuống để tiện chọn
        cbbox_port.DroppedDown = True
    End Sub
    ' khi nhấn button CONNECT thì hàm này thực hiện
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        ' vô hiệu button CONNECT và đạp ra phía sau để button DISCONNECT hiện lên trên (do 2 button chồng lên nhau)
        btn_connect.Enabled = False
        btn_connect.SendToBack()
        ' baurate của port serial sẽ mở = baudrate chọn trong combobox
        SerialPort1.BaudRate = cbbox_baud.SelectedItem
        ' name của port serial sẽ mở = name chọn trong combobox
        SerialPort1.PortName = cbbox_port.SelectedItem
        Try
            ' mở port serial
            SerialPort1.Open()
            ' biến comOpen bằng trạng thái mở port (= 1 nếu port dc mở, = 0 nếu port chưa mở)
            comOpen = SerialPort1.IsOpen
        Catch ex As Exception
            ' nếu mở ko dc port thì báo lỗi
            comOpen = False
            MessageBox.Show("Can not open COM Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' kích hoạt button DISCONNECT và cho trồi lên trên, đè button CONNECT
        btn_disconnect.Enabled = True
        btn_disconnect.BringToFront()
        'th_CO = Integer.Parse(txtbox_th_CO.Text)
        'th_smoke = Integer.Parse(txtbox_th_smoke.Text)
        'th_humidity = Integer.Parse(txtbox_th_humid.Text)
        'th_temperature = Integer.Parse(txtbox_th_temp.Text)
    End Sub
    ' khi nhấn button DISCONNECT thì hàm này thực hiện
    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        ' vô hiệu hóa button DISCONNECT và quăng ra sau, nhường button CONNECT hiện lên
        btn_disconnect.Enabled = False
        btn_disconnect.SendToBack()
        ' đóng serial port
        SerialPort1.Close()
        ' kích hoạt button CONNECT và cho trồi lên
        btn_connect.Enabled = True
        btn_connect.BringToFront()
    End Sub
    ' hàm này chạy khi có truyền nhận dữ liệu qua serial port <-  nhận được data từ arduino gửi lên
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If comOpen Then
            Try
                'biến readBuffer = dữ liệu nhận được (biến này kiểu chuỗi string) và dữ liệu get theo dòng, hết dòng là xong 1 chuỗi dữ liệu
                readBuffer = SerialPort1.ReadLine()
                'data to UI thread
                Me.Invoke(New EventHandler(AddressOf DoUpdate))
            Catch ex As Exception
                'MsgBox("read " & ex.Message)
            End Try
        End If
    End Sub
    ' hàm này chạy cập nhật giao diện hiển thị chương trình mỗi khi nhận được dữ liệu
    Public Sub DoUpdate(ByVal sender As Object, ByVal e As System.EventArgs)
        ' chuỗi dữ liệu gửi từ arduino có dạng trạng thái led 1, led2, fan1, fan2, led3, giá trị MQ7, MQ2
        ' mỗi chuỗi dữ liệu sẽ gồm 19 kí tự (tính cả dấu ",") ví dụ: "0,0,0,0,1,123,456"
        ' biến status_led_1 là kiểu số nguyên, còn readBuffer là kiểu chuỗi string, nên cần chuyển từ kí tự qua số
        ' dùng hàm Interger.Parse --> ví dự chuỗi "123" sẽ thành số nguyên 123
        ' hàm mid(readbuffer,3,1) có nghĩa là lấy chuỗi giá trị trong readbuffer, bắt đầu từ kí tự số 3, lấy 1 kí tự
        ' ví dụ chuỗi readbuffer nhận được là "0,0,0,0,1,123,456"
        ' vậy mid(readbuffer,3,1) sẽ là: kí tự thứ 3 tức là số 0,lấy 1 kí tự là lấy đúng nó --> status_led_2 = 0
        status_led_1 = Integer.Parse(Mid(readBuffer, 1, 1))
        status_led_2 = Integer.Parse(Mid(readBuffer, 3, 1))
        status_fan_1 = Integer.Parse(Mid(readBuffer, 5, 1))
        status_fan_2 = Integer.Parse(Mid(readBuffer, 7, 1))
        status_led_3 = 1 - Integer.Parse(Mid(readBuffer, 9, 1))
        ' textbox báo giá trị CO và Smoke sẽ hiện giá trị đọc được từ chuỗi trên
        txtbox_co.Text = Mid(readBuffer, 11, 3)
        txtbox_smoke.Text = Mid(readBuffer, 15, 3)
        ' gán biến giá trị MQ7 và MQ2 (CO và smoke)
        value_MQ7 = Integer.Parse(Mid(readBuffer, 11, 3))
        value_MQ2 = Integer.Parse(Mid(readBuffer, 15, 3))
        ' nếu trạng thái led 1 = 0
        If status_led_1 = 0 Then
            ' cho ảnh led 1 thành ảnh led tắt
            img_led_1.Image = Image.FromFile("led_off.png")
            ' nếu trạng thái led 1 = 1 thì cho ảnh led1 thành led sáng
        Else img_led_1.Image = Image.FromFile("led_on.jpg")
        End If

        If status_led_2 = 0 Then
            img_led_2.Image = Image.FromFile("led_off.png")
        Else img_led_2.Image = Image.FromFile("led_on.jpg")
        End If

        If status_led_3 = 0 Then
            img_led_3.Image = Image.FromFile("led_off.png")
        Else img_led_3.Image = Image.FromFile("led_on.jpg")
        End If

        If status_fan_1 = 0 Then
            img_fan_1.Image = Image.FromFile("fan_off.png")
        Else img_fan_1.Image = Image.FromFile("fan_on.png")
        End If

        If status_fan_2 = 0 Then
            img_fan_2.Image = Image.FromFile("fan_off.png")
        Else img_fan_2.Image = Image.FromFile("fan_on.png")
        End If

        ' phần cảnh báo caution - warning
        ' nếu giá trị khí CO > giá trị ngưỡng CO đặt
        If value_MQ7 > Integer.Parse(txtbox_th_CO.Text) Then
            ' chèn hình báo có cháy
            img_alarm_CO.Image = Image.FromFile("gas.png")
        Else
            ' nếu giá trị khí CO < giá trị ngưỡng CO đặt thì ẩn hình báo cháy
            img_alarm_CO.Image = Nothing
        End If
        ' nếu giá trị khói > giá trị ngưỡng khói đặt
        If value_MQ2 > Integer.Parse(txtbox_th_smoke.Text) Then
            ' chèn hình báo có khói
            img_alarm_smoke.Image = Image.FromFile("smoke.png")
        Else
            ' nếu giá trị khói < giá trị ngưỡng khói đặt thì ẩn hình báo khói
            img_alarm_smoke.Image = Nothing
        End If

        ' nếu giá trị khí CO > giá trị ngưỡng CO đặt hoặc giá trị khói > giá trị ngưỡng khói đặt
        If (value_MQ7 > Integer.Parse(txtbox_th_CO.Text) Or value_MQ2 > Integer.Parse(txtbox_th_smoke.Text)) Then
            ' hiện hình cảnh báo caution
            img_alarm.Image = Image.FromFile("caution.jpg")
        Else
            ' hiện hình ngôi nhà báo mọi thứ đều ổn
            img_alarm.Image = Image.FromFile("home.png")
        End If
    End Sub
End Class