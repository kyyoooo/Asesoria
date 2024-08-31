int trig = 9;  // Pin para el Trigger
int echo = 10; // Pin para el Echo

void setup() {
  Serial.begin(9600);  // Iniciar comunicación serial
  pinMode(trig, OUTPUT);  // Establecer trig como salida
  pinMode(echo, INPUT);   // Establecer echo como entrada
}

void loop() {
  long tiempo, distancia; // definimos variables para guardar el tiempo y distancia del ultrasonico
  digitalWrite(trig, LOW);
  delayMicroseconds(2);
  digitalWrite(trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig, LOW);
  tiempo = pulseIn(echo, HIGH); // hasta aqui hacemos que una onda vaya y regrese, la variable tiempo sera el tiempo que tardo en ir y regresar esa onda
  distancia = (tiempo/ 2) / 29.1; // para sacar la distancia, dividimos el tiempo que tardo en regresar la onda entre la velocidad del sonido en el aire que es 29.1

  if(distancia > 0 && distancia <= 5){ // Si detectamos algo a menos de 5 cm
    Serial.write('0'); // manda un 0 al visual
  }else{ // de lo contrario manda un 1
    Serial.write('1');
  }
  if(distancia > 5 && distancia <= 10){ // si detectamos algo a menos de 10 cm
    Serial.write('2'); // manda un 2
  }else{ // de lo contrario manda un 3
    Serial.write('3');
  }
  if(distancia > 10 && distancia <= 15){ // si detectamos algo a menos de 15 cm
    Serial.write('4'); // manda un 4
  }else{ // de lo contrario manda un 5
    Serial.write('5');
  }
  if(distancia > 15 && distancia <= 20){ // si detectamos algo a menos de 20 cm
    Serial.write('6'); // manda un 6 
  }else{ // de lo contrario manda un 7
    Serial.write('7');
  }
  delay(100);
}
