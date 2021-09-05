// khai báo thư viện sử dụng
#include <Arduino.h>
#include <TimerOne.h>
#include <DHT.h>

// khai báo chuỗi kí tự trắng để truyền nhận dữ liệu
String inputString = "";
// cờ báo đã nhận xong dữ liệu
boolean stringComplete = false;
// cờ báo có dữ liệu truyền hoặc nhận
int flag_data = 0;
// khai báo chân kích relay
const int led_1 = 9;
const int fan_1 = 8;
const int led_2 = 7;
const int fan_2 = 6;
const int led_3 = 10;
const int buzzer = 11;
const int pump = 12;
// Khai báo chân sensor MQ7
const int sensor_Q7 = A1;
int value_Q7;
// Khai báo chân sensor MQ2
const int sensor_Q2 = A0;
int value_Q2;
// Khai báo chân sensor DHT11
const int DHTPIN = 5;
const int DHTTYPE = DHT11;
DHT dht(DHTPIN, DHTTYPE);
int h = 0;
int t = 0; 
// Khai báo biến báo trạng thái thiết bị
bool stt_led_1 = 0;
bool stt_led_2 = 0;
bool stt_led_3 = 0;
bool stt_fan_1 = 0;
bool stt_fan_2 = 0;

// Thiết lập ban đầu
void setup() 
{  
  // Khai báo chân output
  pinMode(led_1, OUTPUT); 
  pinMode(fan_1, OUTPUT); 
  pinMode(led_2, OUTPUT); 
  pinMode(fan_2, OUTPUT);
  pinMode(led_3, OUTPUT); 
  pinMode(buzzer, OUTPUT);  
  pinMode(pump, OUTPUT);
  // Khai báo chân input
  pinMode(sensor_Q7, INPUT); 
  pinMode(sensor_Q2, INPUT);
  // Thiết lập trạng thái đầu cho thiết bị
  digitalWrite(led_1, LOW);
  digitalWrite(fan_1, LOW);
  digitalWrite(led_2, LOW);
  digitalWrite(fan_2, LOW); 
  digitalWrite(led_3, HIGH);
  digitalWrite(buzzer, HIGH);  
  digitalWrite(pump, HIGH);
  // Khởi tạo timer chu kì 1s, cứ sau mỗi 1s sẽ thực hiện hàm ngắt timer timerIsr
  Timer1.initialize(1000000);
  // Khai báo hàm ngắt timer
  Timer1.attachInterrupt(timerIsr);
  // Tạo serial port với baudrate 9600
  Serial.begin(9600);  
  // Chuỗi nhận dữ liệu 200byte
  inputString.reserve(200);  
  // Chạy sensor DHT11
  dht.begin();
}

void loop() 
{
  // Đọc dữ liệu sensor MQ7 (nồng độ khí CO) & MQ2 (báo khói)
  value_Q7 = analogRead(sensor_Q7);
  value_Q2 = analogRead(sensor_Q2);
  // Đọc dữ liệu sensor DHT11: nhiệt độ + độ ẩm
  h = dht.readHumidity();
  t = dht.readTemperature()-4;   
  // Đọc trạng thái thiết bị
  stt_led_1 = digitalRead(led_1);
  stt_led_2 = digitalRead(led_2);
  stt_fan_1 = digitalRead(fan_1);
  stt_fan_2 = digitalRead(fan_2);
  stt_led_3 = digitalRead(led_3);

  // Khi nhận được dữ liệu truyền xuống
  if (flag_data == 1)
  {
    if (inputString == "A") // nếu nhận được kí tự "A"
    {
      digitalWrite(led_1, HIGH);    // bật đèn led_1 
      //Serial.println("Led_1 ON!!!"); 
    }
     else if (inputString == "a")
    {     
      digitalWrite(led_1, LOW);     
      //Serial.println("Led_1 OFF!!!"); 
    }
     else if (inputString == "B")
    {
      digitalWrite(led_2, HIGH);     
      //Serial.println("Led_2 ON!!!"); 
    }
     else if (inputString == "b")
    {     
      digitalWrite(led_2, LOW);     
      //Serial.println("Led_2 OFF!!!"); 
    }
     else if (inputString == "C")
    {
      digitalWrite(led_3, LOW);     
      //Serial.println("Led_3 ON!!!"); 
    }
     else if (inputString == "c")
    {     
      digitalWrite(led_3, HIGH);     
      //Serial.println("Led_3 OFF!!!"); 
    }
     else if (inputString == "f")
    {
      digitalWrite(led_1, HIGH); 
      digitalWrite(led_2, HIGH); 
      digitalWrite(led_3, LOW); 
      digitalWrite(fan_1, HIGH); 
      digitalWrite(fan_2, HIGH);      
      //Serial.println("ALL ON!!!");
    }
     else if (inputString == "F")
    {
      digitalWrite(led_1, LOW); 
      digitalWrite(led_2, LOW); 
      digitalWrite(led_3, HIGH); 
      digitalWrite(fan_1, LOW); 
      digitalWrite(fan_2, LOW);  
      digitalWrite(pump, HIGH);
      digitalWrite(buzzer, HIGH);   
      //Serial.println("ALL OFF!!!"); 
    }
    else if (inputString == "D")
    {
      digitalWrite(fan_1, HIGH);     
      //Serial.println("Fan_1 ON!!!"); 
    }
     else if (inputString == "d")
    {     
      digitalWrite(fan_1, LOW);     
      //Serial.println("Fan_1 OFF!!!"); 
    }
     else if (inputString =="E")
    {
      digitalWrite(fan_2, HIGH);     
      //Serial.println("Fan_2 ON!!!"); 
    }
     else if (inputString == "e")
    {     
      digitalWrite(fan_2, LOW);     
     //Serial.println("Fan_2 OFF!!!"); 
    }
     else if (inputString == "G")
    {
      digitalWrite(buzzer, LOW);     
      //Serial.println("Buzzer ON!!!"); 
    }
     else if (inputString == "g")
    {     
      digitalWrite(buzzer, HIGH);     
      //Serial.println("Buzzer OFF!!!"); 
    }
     else if (inputString == "H")
    {
      digitalWrite(pump, LOW);     
      //Serial.println("Pump ON!!!"); 
    }
     else if (inputString == "h")
    {     
      digitalWrite(pump, HIGH);     
      //Serial.println("Pump OFF!!!"); 
    }
     else if (inputString == "T")
    {
      digitalWrite(led_1, LOW); 
      digitalWrite(led_2, LOW);  
      digitalWrite(fan_1, LOW); 
      digitalWrite(fan_2, LOW);      
      digitalWrite(led_3, HIGH);         
      digitalWrite(buzzer, LOW);
      digitalWrite(pump, LOW); 
      //Serial.println("ALARM ON!!!"); 
    }
     else if (inputString == "t")
    {
      digitalWrite(pump, HIGH);
      digitalWrite(buzzer, HIGH);          
      //Serial.println("ALARM OFF!!!"); 
    }
    //else Serial.println("Wrong Command"); 
    inputString = "";
    flag_data=0;  
  }      
}

void serialEvent()  // hàm ngắt, xảy ra khi có truyền nhận dữ liệu sẽ thực thi trong hàm này
{
  while (Serial.available())  // khi có truyền nhận dữ liệu
  {
    // bật cờ có dữ liệu lên 1
    flag_data = 1;
    // chép dữ liệu nhận được vào biến inChar
    char inChar = (char)Serial.read(); 
    // cộng dồn kí tự từ inChar thành chuỗi inputString:
    inputString += inChar;
    // nếu kí tự nhận được là kí tự xuống dòng (bắt đầu dòng mới) thì bật cờ stringComplete
    if (inChar == '\n') 
    {
      stringComplete = true;    
    }  
  } 
}
