
byte Houselight = 53;
byte Ligth= A1;
byte Tone= 51; 
byte Response1 = 6;
byte Response2 = 7;
byte ResponsePhotocell = A0;
int Response_lower_limit = 1;
byte Step_RightCW = 37;
byte Dir_RightCLK = 39;
int StepCount = 0;
byte WaterDispenser= 2; 

//Change XXX for the apropiate value 
int Response_upper_limit = XXX;

void setup(){
  Serial.begin(9600);
  pinMode(Houselight, OUTPUT);
  pinMode(Ligth, OUTPUT);
  pinMode(Tone, OUTPUT);
  pinMode(Step_Right, OUTPUT);
  pinMode(Dir_Right, OUTPUT);
  pinMode(WaterDispenser, OUTPUT);
  pinMode(Response1,INPUT_PULLUP);
  pinMode(Response2,INPUT_PULLUP);
    
  digitalWrite(Houselight,LOW);
  digitalWrite(Ligth, LOW);
  digitalWrite(Tone, LOW);
  digitalWrite(WaterDispenser, LOW);
  digitalWrite (Dir_Right, HIGH);
  
}
void loop(){

  if (Serial.available()>0){

    char Event=Serial.read();
    switch (Event){

    case 'H':
      digitalWrite (Houselight, HIGH);
      break;
       case 'h':
      digitalWrite (Houselight, LOW);
      break;
      
     case 'A':
      digitalWrite (Ligth, HIGH);
      break;
      
      case 'a':
      digitalWrite (Ligth, LOW);
      break;
      
       case 'T':
      digitalWrite (Tone, HIGH);
      break;
      
      case 't':
      digitalWrite (Tone, LOW);
      break;
      
   case 'R':
      for (StepCount = 0; StepCount < 80; StepCount++){
      digitalWrite(Step_Right,HIGH);
      delay(5);
      digitalWrite(Step_Right,LOW);
      delay(5);    
        }
         break;
      
    case 'W':
      digitalWrite(WaterDispenser,HIGH);
      delay(500);
      digitalWrite (WaterDispenser,LOW);
      break;
      
    case 'E':
      digitalWrite(Feeder,LOW);
      digitalWrite(Houselight,LOW);
      digitalWrite (WaterDispenser,LOW);
      digitalWrite (Tone, LOW);
      digitalWrite (Ligth, LOW);
      break;
    }
  }
   Serial.println(String(digitalRead(Response1))+","+(String(digitalRead(Response2)));
  delay (4);
  
   if (analogRead(Response)>Response_upper_limit || analogRead(Response)<Response_lower_limit){
    Serial.println("0");
  }
    else if (analogRead(Response)>=Response_lower_limit && analogRead(Response)<=Response_upper_limit){
    Serial.println("1");
  }

  delay (30);
}
