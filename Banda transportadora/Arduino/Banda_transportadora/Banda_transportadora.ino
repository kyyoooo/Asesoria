#include <Servo.h> // Con esta libreria la usamos para poder usar comandos del servomotor
Servo myservo; // nombramos el servo como myservo

int motor = 2; // usaremos el pin 2 para accionar el motor
bool valorParoEmergencia; // creamos variables para hacer el paro y arranque 
bool valorParo;
bool valArr;
bool direccionDerecho; // creamos variables para el cambio del servomotor
bool direccionDesvio;

int derecho = 0; // damos a la variable derecho un angulo de 0 para que quede recto el servo
int desvio  = 70; // damos a la variable desvio un angulo de 70 para que cree un desvio

void setup(){
  pinMode(motor, OUTPUT); // configuramos el motor como salida
  Serial.begin(9600); // iniciamos la comunicacion con la computadora
  myservo.attach(6); // este comando de la libreria hace referencia a que pin y que configuracion tendra el servo
  myservo.write(0); // iniciamos el servo en el angulo 0 desde un inicio
}

void loop(){
  if(Serial.available()>0){ // condicionamos las entradas de señal leyendo lo que nos manda la computadora al arduino
    int numero = Serial.read(); // los datos recibidos los guardamos en la variable "numero"
    if(numero == '1'){ // si la computadora nos manda un "1"
      valorParoEmergencia = true; // indica que el paro de emergencia es presionado
      }
    if(numero == '2'){// si la computadora nos manda un "2"
      valorParoEmergencia = false; // indica que el paro de emergencia  no es presionado 
      }
    if(numero == '3'){ // si la computadora nos manda un "3"
      valorParo = true; // indica que el paro es presionado
      }
    if(numero == '4'){ // si la computadora nos manda un "4"
      valorParo = false; // indica que el paro no es presionado
      }
    if(numero == '5'){ // si la computadora nos manda un "5"
      valArr = true; // indica que el arranque es presionado
      }
    else{ // si la computadora nos manda otro numero que no sea 5
      valArr = false; // indica que el arranque no es presionado
      }
    if(numero == '6'){ // si la computadora nos manda un "6"
      direccionDerecho = true; // indica que el boton de la flecha tiene una opcion
      }
    if(numero == '7'){ // si la computadora nos manda un "7"
      direccionDerecho = false; // indica que el boton de la flecha tiene otra opcion
      }


    if(valorParoEmergencia == true) // si el boton de paro de emergencia esta cerrado
    {
      if(direccionDerecho == true) // si el boton de direccion esta presionado en derecho
      {
        myservo.write(derecho); // el servo estara en la posicion de derecho
      }
      else if(direccionDerecho == false) // si el boton de direccion está presionado en desvio
      {
        myservo.write(desvio); // el servo estara en la posicion de desvio
      }
        
      if(valArr == true && valorParo == true) // si el boton de arranque es presionado
      {
        digitalWrite(motor,HIGH); // inicia el motor
      }
      if(valorParo == false) // si el boton de paro es presionado 
      {
        digitalWrite(motor, LOW); // el motor se para
        myservo.write(derecho); // el servo vuelve a su estado natural
      }
    }
    if(valorParoEmergencia == false) // si el boton de paro de emergencia esta abierto
    {
      digitalWrite(motor, LOW); // el motor se para
      myservo.write(derecho); // el servo vuelve a su estado natural
    }
    delay(100);
  }
}
