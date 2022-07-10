//lcd
#include <Wire.h>
//config i2c lcd
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 20, 4);
//config i2c mcp
#include "Adafruit_MCP23017.h"
Adafruit_MCP23017 mcp;
//servo
#include <Servo.h>
Servo myservo1;
Servo myservo2;
Servo myservo3;
Servo myservo4;
//var bluthoot
int estado = 0;
long prim = 0, seg = 0, ter = 0, cuart = 0, reprim = 0, reseg = 0, reter = 0, recuart = 0;
long lcdprim, lcdseg, lcdter, lcdcuart;
//variable de la cantidad de pastillas
int can1=0,can2=0,can3=0,can4=0;
int maskcan1=0,maskcan2=0,maskcan3=0,maskcan4=0;
//bluthoot config
#include <SoftwareSerial.h>
SoftwareSerial mySerial(10, 11); // RX, TX
//recepcion de datos
  String s="";
  char c=0;
  boolean newline=false;
  
  String slcdprim="";
  String slcdseg="";
  String slcdter="";
  String slcdcuart="";
  
  String scan1="";
  String scan2="";
  String scan3="";
  String scan4="";
void setup()
{
  //buzzer setup
  pinMode(13,OUTPUT);
  digitalWrite(13,HIGH);
  //mcp config pinout
  mcp.begin();
  for(int i=0;i<8;i++)
  {
    mcp.pinMode(i, OUTPUT);
  }
  for(int i=0;i<12;i++)
   {
    mcp.digitalWrite(i,LOW);
   }
   
  //servo setup
  myservo1.attach(3);
  myservo2.attach(5);
  myservo3.attach(6);
  myservo4.attach(9);
  
  myservo1.write(90);
  myservo2.write(90);
  myservo3.write(90);
  myservo4.write(90);
  // bluthoot setup
  mySerial.begin(9600);
  Serial.begin(9600);
  //LCD setup
  lcd.init();
  lcd.backlight();
  lcd.print("TU PASTILLERO");
  lcd.setCursor(0, 1);
  lcd.print("INICIANDO.....");
  lcd.setCursor(0, 2);
  lcd.print("Jose Enrique");
  lcd.setCursor(0, 3);
  lcd.print("Castillo Nava");
  delay(2500);
  lcd.clear();
  
}

void loop()
{
  while(mySerial.available()>0)
  {
    c=mySerial.read();
    if(c=='\r')
    continue;
    else if(c=='\n')
    {
      newline=true;
      break;
    }
    else
    s=s+c;
  }

  if(newline)
  {
  int n=s.length();
  char arreglo[n+1];
    s.toCharArray(arreglo,n+1);
    int j=0;
    //primer variable--------------------------------------------------------------------
    for(j;j<n;j++)
    {
      if(arreglo[j]=='A')
      {
        break;
      }
      slcdprim=slcdprim+arreglo[j];//svar1 cambiar por slcdprim
    }
    lcdprim=slcdprim.toInt();
    prim = (lcdprim * 1000) + millis();
    j++;
    
    //segunda variable tiempo lcd--------------------------------------------------------
    for(j;j<n;j++)
    {
      if(arreglo[j]=='B')
      {
        break;
      }
      slcdseg=slcdseg+arreglo[j];//svar1 cambiar por slcdprim
    }
    lcdseg=slcdseg.toInt();
    seg = (lcdseg * 1000) + millis();
    j++;
    
    //tercer variable tiempo lcd--------------------------------------------------------
    for(j;j<n;j++)
    {
      if(arreglo[j]=='C')
      {
        break;
      }
      slcdter=slcdter+arreglo[j];//svar1 cambiar por slcdprim
    }
    lcdter=slcdter.toInt();
    ter = (lcdter * 1000) + millis();
    j++;

    //cuarta variable tiempo lcd--------------------------------------------------------
     for(j;j<n;j++)
    {
      if(arreglo[j]=='D')
      {
        break;
      }
      slcdcuart=slcdcuart+arreglo[j];//svar1 cambiar por slcdprim
    }
    lcdcuart=slcdcuart.toInt();
    cuart = (lcdcuart * 1000) + millis();
    j++;
    
    //primera cantidad de pastillas--------------------------------------------------------
    for(j;j<n;j++)
    {
      if(arreglo[j]=='E')
      {
        break;
      }
      scan1=scan1+arreglo[j];//svar1 cambiar por slcdprim
    }
    can1=scan1.toInt();
    maskcan1=can1;
    j++;
    
    //segunda cantidad de pastillas--------------------------------------------------------
    for(j;j<n;j++)
    {
      if(arreglo[j]=='F')
      {
        break;
      }
      scan2=scan2+arreglo[j];//svar1 cambiar por slcdprim
    }
    can2=scan2.toInt();
    maskcan2=can2;
    j++;

    //tercera cantidad de pastillas--------------------------------------------------------
    for(j;j<n;j++)
    {
      if(arreglo[j]=='G')
      {
        break;
      }
      scan3=scan3+arreglo[j];//svar1 cambiar por slcdprim
    }
    can3=scan3.toInt();
    maskcan3=can3;
    j++;
    
    //cuarta cantidad de pastillas--------------------------------------------------------
    for(j;j<n;j++)
    {
      scan4=scan4+arreglo[j];//svar1 cambiar por slcdprim
    }
    can4=scan4.toInt();
    maskcan4=can4;
//se recicla la variable oea se igual a nada------------------------------------------------
    s="";
    slcdprim="";
    slcdseg="";
    slcdter="";
    slcdcuart="";
    scan1="";
    scan2="";
    scan3="";
    scan4="";
    newline=false;    
    
    }
//tiempo real
    reprim =reseg=reter=recuart= millis();
  
  if (lcdprim > 0 && can1>0)
  {
    if (prim < reprim)
    {
      digitalWrite(13,LOW);
      myservo1.write(1);
      delay(500);
      digitalWrite(13,HIGH);
      myservo1.write(90);
      prim = prim + lcdprim * 1000;
      can1--;
//      Serial.print(prim);
//      Serial.println("----------------------------");
    }
  }
  if (lcdseg > 0 && can2>0)
  {
    if (seg < reseg)
    {
      digitalWrite(13,LOW);
      myservo2.write(1);
      delay(500);
      digitalWrite(13,HIGH);
      myservo2.write(90);
      seg = seg + lcdseg * 1000;
      can2--;
    }
  }

  if (lcdter > 0 && can3>0)
  {
    if (ter < reter)
    {
      digitalWrite(13,LOW);
      myservo3.write(1);
      delay(500);
      digitalWrite(13,HIGH);
      myservo3.write(90);
      ter = ter + lcdter * 1000 ;
      can3--;
    }
  }

  if (lcdcuart > 0 && can4>0)
  {
    if (cuart < recuart)
    {
      digitalWrite(13,LOW);
      myservo4.write(1);
      delay(500);
      digitalWrite(13,HIGH);
      myservo4.write(90);
      cuart = cuart + lcdcuart * 1000;
      can4--;
    }
  }

//comparador de cantidad y leds primero---------------------------------------------
  if(can1>maskcan1/2)
  {//
    mcp.digitalWrite(0,LOW);//color rojo
    mcp.digitalWrite(1,HIGH);//color verde
  }
  if(can1<maskcan1/2 && can1 !=0)
  {//esta medio lleno 
    mcp.digitalWrite(0,HIGH);
    mcp.digitalWrite(1,HIGH);
  }
  if(can1==0)
  {//el led esta en rojo osea que no tiene nada 
    mcp.digitalWrite(0,HIGH);
    mcp.digitalWrite(1,LOW);
  }
  //comparador de cantidad y leds segundo---------------------------------------------
  if(can2>maskcan2/2)
  {
    mcp.digitalWrite(2,LOW);
    mcp.digitalWrite(3,HIGH);
  }
  if(can1<maskcan2/2 && can2 !=0)
  {
    mcp.digitalWrite(2,HIGH);
    mcp.digitalWrite(3,HIGH);
  }
  if(can2==0)
  {
    mcp.digitalWrite(2,HIGH);
    mcp.digitalWrite(3,LOW);
  }
  //comparador de cantidad y leds tercero---------------------------------------------
  if(can3>maskcan3/2)
  {
    mcp.digitalWrite(4,LOW);
    mcp.digitalWrite(5,HIGH);
  }
  if(can3<maskcan3/2 && can3 !=0)
  {
    mcp.digitalWrite(4,HIGH);
    mcp.digitalWrite(5,HIGH);
  }
  if(can3==0)
  {
    mcp.digitalWrite(4,HIGH);
    mcp.digitalWrite(5,LOW);
  }
  //comparador de cantidad y leds cuarto---------------------------------------------
  if(can4>maskcan4/2)
  {
    mcp.digitalWrite(6,LOW);
    mcp.digitalWrite(7,HIGH);
  }
  if(can4<maskcan4/2 && can4 !=0)
  {
    mcp.digitalWrite(6,HIGH);
    mcp.digitalWrite(7,HIGH);
  }
  if(can4==0)
  {
    mcp.digitalWrite(6,HIGH);
    mcp.digitalWrite(7,LOW);
  }
  
  ///Serial.println(pasvis);
  lcd.setCursor(0, 0);
  lcd.print("pill 1-");
  lcd.print(lcdprim);
  lcd.print("|| cant-");
  lcd.print(can1);
  lcd.print(" ");
  lcd.setCursor(0, 1);
  lcd.print("pill 2-");
  lcd.print(lcdseg);
  lcd.print("|| cant-");
  lcd.print(can2);
  lcd.print(" ");
  lcd.setCursor(0, 2);
  lcd.print("pill 3-");
  lcd.print(lcdter);
  lcd.print("|| cant-");
  lcd.print(can3);
  lcd.print(" ");
  lcd.setCursor(0, 3);
  lcd.print("pill 4-");
  lcd.print(lcdcuart);
  lcd.print("|| cant-");
  lcd.print(can4);
  lcd.print(" ");
}
