int cantidadPines = 5;
int pines[] = {9, 10, 11, 12, 13};

void setup(){
    Serial.begin(9600);
    for (size_t i = 0; i < cantidadPines; i++){
        pinMode(pines[i], OUTPUT);
    }
}
void loop(){
    String dato;
    if(Serial.available()){
        dato = Serial.readStringUntil('\n');
        if(dato.toInt() > 0){
            digitalWrite(dato.toInt(), HIGH);
        }else if(dato.toInt() < 0){
            digitalWrite(abs(dato.toInt()), LOW);
        }
    }
}