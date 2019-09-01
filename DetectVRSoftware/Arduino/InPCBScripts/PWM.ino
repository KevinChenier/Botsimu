byte Csharp;
int Pin = 3;

void setup() {
 Serial.begin(9600);      // opens serial port, sets data rate to 9600 bps
 pinMode(Pin, OUTPUT);
}

void loop() {

 if (Serial.available() > 0) {
   
   Csharp = Serial.read();

   Serial.println(Csharp,DEC);
 
   analogWrite(Pin, int(Csharp));

 }
}
