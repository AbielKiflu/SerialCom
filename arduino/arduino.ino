String data;


void setup() {

  Serial.begin(9600);
  pinMode(13,OUTPUT);
}

void loop() {
 
  if(Serial.available()){
    data=Serial.readString();

    if(data =="OFF"){
      digitalWrite(13, LOW);
      Serial.println("Hi there, it is OFF");
    }else{
       digitalWrite(13, HIGH);
        Serial.println("Hi there, it is ON");
    }
  }

  

}
