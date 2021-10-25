byte Houselight = 11;
byte Sonalert = 10;
byte Response_1 = 7;
byte Response_2= 6;
byte Response_3= 5;
byte Response_4= 4;
byte Response_5= 3;
byte Light_1= A0;
byte Light_2 = A1;
byte Light_3= A2;
byte Light_4 = A3;
byte Light_5= A4;
byte Light_6 = A5;
byte Light_7= A6;
byte Light_8 = A7;
byte Step_Right = 12;
byte Dir_Right = 9;
int StepCount = 0;
void setup(){
  Serial.begin(9600);
  pinMode(Light_1, OUTPUT);
  pinMode(Light_2, OUTPUT);
  pinMode(Light_3, OUTPUT);
  pinMode(Light_4, OUTPUT);
  pinMode(Light_5, OUTPUT);
  pinMode(Light_6, OUTPUT);
  pinMode(Light_7, OUTPUT);
  pinMode(Light_8, OUTPUT);
  pinMode(Houselight, OUTPUT);
   pinMode(Sonalert, OUTPUT);
  pinMode(Step_Right, OUTPUT);
  pinMode(Dir_Right, OUTPUT);
  pinMode(Response_1,INPUT_PULLUP);
  pinMode(Response_2,INPUT_PULLUP);
   pinMode(Response_3,INPUT_PULLUP);
  pinMode(Response_4,INPUT_PULLUP);
   pinMode(Response_5,INPUT_PULLUP);
 
  digitalWrite (Light_1,LOW);
  digitalWrite (Light_2,LOW);
  digitalWrite (Light_3,LOW);
  digitalWrite (Light_4,LOW);
  digitalWrite (Light_5,LOW);
  digitalWrite (Light_6,LOW);
  digitalWrite (Light_7,LOW);
  digitalWrite (Light_8,LOW);
  digitalWrite (Houselight,LOW);
   digitalWrite (Sonalert,LOW);
  digitalWrite (Dir_Right, HIGH);
}
void loop(){

  if (Serial.available()>0){

    char Event=Serial.read();
    switch (Event){

    case 'A':
      digitalWrite (Light_1, HIGH);
      break;
    case 'a':
      digitalWrite (Light_1, LOW);
      break;
    case 'B':
      digitalWrite (Light_2, HIGH);
      break;
    case 'b':
      digitalWrite (Light_2, LOW);
      break;
       case 'C':
      digitalWrite (Light_3, HIGH);
      break;
    case 'c':
      digitalWrite (Light_3, LOW);
      break;
       case 'D':
      digitalWrite (Light_4, HIGH);
      break;
    case 'd':
      digitalWrite (Light_4, LOW);
      break;
       case 'E':
      digitalWrite (Light_5, HIGH);
      break;
    case 'e':
      digitalWrite (Light_5, LOW);
      break;
       case 'F':
      digitalWrite (Light_6, HIGH);
      break;
    case 'f':
      digitalWrite (Light_6, LOW);
      break;
       case 'G':
      digitalWrite (Light_7, HIGH);
      break;
    case 'g':
      digitalWrite (Light_7, LOW);
      break;
       case 'H':
      digitalWrite (Light_8, HIGH);
      break;
    case 'h':
      digitalWrite (Light_8, LOW);
      break;
      
    case 'R':
      for (StepCount = 0; StepCount < 80; StepCount++){
      digitalWrite(Step_Right,HIGH);
      delay(5);
      digitalWrite(Step_Right,LOW);
      delay(5);    
        }
         break;
    case 'T':
     digitalWrite (Sonalert, HIGH);
      delay(500); 
      digitalWrite(Sonalert, LOW);
        break;
       case 'Z':
     digitalWrite (Sonalert, HIGH);
     break;
       case 'z':
      digitalWrite(Sonalert, LOW);
        break;
     case 'Q':
     digitalWrite (Houselight, HIGH);
      delay(500); 
      digitalWrite(Houselight, LOW);
        break;    
       
    case 'P':
      digitalWrite(Sonalert,LOW);
      digitalWrite(Houselight,LOW);
      digitalWrite (Light_1, LOW);
      digitalWrite (Light_2, LOW);
       digitalWrite (Light_3, LOW);
      digitalWrite (Light_4, LOW);
      digitalWrite (Light_5, LOW);
      digitalWrite (Light_6, LOW);
       digitalWrite (Light_7, LOW);
      digitalWrite (Light_8, LOW);
      delay(500);
      break;
    }
  }
  Serial.println(String(digitalRead(Response_1))+","+String(digitalRead(Response_2))+","+String(digitalRead(Response_3))+","+String(digitalRead(Response_4))+","+String(digitalRead(Response_5)));
  delay (4);
}
