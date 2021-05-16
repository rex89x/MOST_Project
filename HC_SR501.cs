const int pir = 10;
const int led =  13; 

void setup() {
    Serial.begin(9600);
    pinMode(pir, INPUT);     
    pinMode(led, OUTPUT);        
}

void loop(){
    byte p = digitalRead(pir);
    if (p == HIGH) {     
        digitalWrite(led, HIGH); 
        Serial.println("Detected");
    } 
    else {
        digitalWrite(led, LOW); 
        Serial.println("No One");
    }
    delay(1000);
}