#include <Arduino.h>
#include<string.h>
#define P1 2
#define P2 3
#define P3 4
#define P4 5
#define START 6
#define LED1 13
#define LED2 12
#define Delay 220
void printer(String msg,int second , int milisecond);
void stoper();
void reset();
void totalTime();
void readSerial();
bool timerStart = false;
int ms = 0;
int ss = 0;
int sss[4];
int mss[4];
int i = 0;
bool StartTouched = false;
bool notTouched1 = true;
bool notTouched2 = true;
bool notTouched3 = true;
bool notTouched4 = true;
String Cmessage = "Stop";
void setup()
{
  Serial.begin(19200);
  pinMode(P1 , INPUT_PULLUP);
  pinMode(P2,INPUT_PULLUP);
  pinMode(P3,INPUT_PULLUP);
  pinMode(P4,INPUT_PULLUP);
  pinMode(START,INPUT_PULLUP);
  pinMode(LED1,OUTPUT);
  pinMode(LED2,OUTPUT);
  digitalWrite(LED1,HIGH);
  noInterrupts();
  TCCR1A = 0;
  TCCR1B = 0;
  TCNT1  = 0;
  OCR1A = 1999;
  TCCR1B |= (1 << WGM12);
  TCCR1B |= (1 << CS11);
  TIMSK1 |= (1 << OCIE1A);
  interrupts();
}

void loop() {
  readSerial();
  if(Cmessage == "Stop"){
    digitalWrite(LED1 , HIGH);
    digitalWrite(LED2 , 0);
    i = 0;
    timerStart = false;
    reset();
  }
  else if (Cmessage == "End")
  {
    timerStart = false;
    ms = 0;
    ss = 0;
    i = 0;
    StartTouched = false;
    notTouched1 = true;
    notTouched2 = true;
    notTouched3 = true;
    notTouched4 = true;
    Cmessage = "Stop";
    delay(100);
  }
  else if(Cmessage == "Start"){
    digitalWrite(LED1,0);
    if (StartTouched)
    {
      digitalWrite(LED2,HIGH);
    }
    else{
      digitalWrite(LED2,HIGH);
      delay(200);
      digitalWrite(LED2,0);
      delay(200);
    }
    if (digitalRead(START) == 0 && timerStart == false)
    {
      while (digitalRead(START) == 0)
      {
        delay(10);
      }
      timerStart = true;
      printer("Start",ss,ms);
      StartTouched = true;
      delay(200);
    }
  }
  if (timerStart == true)
  {
    if (digitalRead(P1) == 0 && notTouched2 == false && notTouched3 == false && notTouched4 == false){
      printer("1",ss,ms);
      mss[i] = ms;
      sss[i] = ss;
      i++;
      reset();
      stoper();
    }
    if (digitalRead(P2) == 0 && notTouched2){
      printer("2",ss,ms);
      mss[i] = ms;
      sss[i] = ss;
      i++;
      reset();
      stoper();
      notTouched2 = false;
    }
    if (digitalRead(P3) == 0 && notTouched3){
      printer("3",ss,ms);
      mss[i] = ms;
      sss[i] = ss;
      i++;
      reset();
      stoper();
      notTouched3 = false;
    }
    if (digitalRead(P4) == 0 && notTouched4){
      printer("4",ss,ms);
      mss[i] = ms;
      sss[i] = ss;
      i++;
      reset();
      stoper();
      notTouched4 = false;
    }
  }
}
void printer(String msg,int second , int milisecond){
  Serial.print(msg);
  Serial.print(':');
  Serial.print(second);
  Serial.print('.');
  Serial.print(milisecond);
  Serial.print('\n');
}
void stoper(){
  if(i == 4){
    timerStart = false;
    delay(Delay);
    totalTime();
    printer("stop",ss,ms);
    reset();
    i = 0;
    StartTouched = false;
    notTouched1 = true;
    notTouched2 = true;
    notTouched3 = true;
    notTouched4 = true;
  }
}
void totalTime()
{
  for (int j = 0; j < 4; j++)
  {
    ss+=sss[j];
    ms+=mss[j];
  }
  ss+=(ms/1000);
  ms%=1000;
}
void reset(){
  ss = 0;
  ms =0;
}
void readSerial()
{
  if (Serial.available())
  {
    Cmessage = Serial.readString();
  }
}
ISR(TIMER1_COMPA_vect)
{   
  if(timerStart == true)
  {
    ms=ms+1;
    if(ms>999)
    {
      ms=0;ss=ss+1;
    }  
  }
}