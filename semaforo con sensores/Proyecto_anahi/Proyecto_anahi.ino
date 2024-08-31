int verde =2;
int ambar =4;
int rojo =7;

int echode =8;
int trigde =9; 
long distanciade;

void setup()
{
  pinMode(2, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(echode, INPUT);
  pinMode(trigde, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  while(true)
  {
    sensor();
    Serial.println(distanciade);

    if (distanciade<= 10)
    {
      semaforo();
    }
    if (distanciade >= 11)
    {
      nosemaforo();
    }
  }
}


void nosemaforo()
{
 
  
  
  digitalWrite(2, HIGH);
  digitalWrite(4, HIGH);
  digitalWrite(7, HIGH);
}

void semaforo()
{
  digitalWrite(2, HIGH);
  digitalWrite(4, HIGH);
  digitalWrite(7, HIGH);
  digitalWrite(2, LOW);
  delay(5000);
  digitalWrite(2, HIGH);

  digitalWrite(4, LOW);
  delay(3000);
  digitalWrite(4, HIGH);  

  digitalWrite(7, LOW);
  delay(5000);
  digitalWrite(7, HIGH);
  }
  
void sensor()
{
  long duracion;
  digitalWrite(trigde, LOW);
  delayMicroseconds(4);
  digitalWrite(trigde, HIGH);
  delayMicroseconds(19);
  digitalWrite(trigde, LOW);
  duracion=pulseIn(echode, HIGH);
  duracion=duracion/2;
  distanciade=duracion/29;
}
