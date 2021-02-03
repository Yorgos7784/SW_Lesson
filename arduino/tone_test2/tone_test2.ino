const int BUZZER = 10;
#define DO1 262
#define RE 294
#define MI 330
#define FA 349
#define SOL 392
#define LA 440
#define SHI 494
#define DO2 523

#define DELAY 300

#include "pitches.h"

const int hakGyo[]{
  NOTE_F5, NOTE_E5, NOTE_F5, NOTE_A5, NOTE_F5, NOTE_E5,
  NOTE_F5, NOTE_E5, NOTE_F5, NOTE_A5, NOTE_F5, NOTE_E5,
  NOTE_F5, NOTE_E5, NOTE_F5, NOTE_G5, NOTE_F5, NOTE_E5,
  NOTE_F5, NOTE_E5, NOTE_F5, NOTE_G5, NOTE_F5, NOTE_E5,
  NOTE_E5, NOTE_D5, NOTE_E5, NOTE_A5, NOTE_E5, NOTE_D5,
  NOTE_E5, NOTE_D5, NOTE_E5, NOTE_A5, NOTE_E5, NOTE_D5,
  NOTE_E5, NOTE_D5, NOTE_E5, NOTE_A5, NOTE_E5, NOTE_D5,
  NOTE_C5, NOTE_B4, NOTE_C5, NOTE_F5, NOTE_C5, NOTE_B4,
  NOTE_C4, 
  
};

const int musicDelay[]{
  500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500
};


void setup() {
  musicStart();
}

void loop() {

}

void musicStart(){
  for(int i = 0; i< sizeof(hakGyo)/sizeof(int); i++){
    tone(BUZZER, hakGyo[i], musicDelay[i]);
    delay(DELAY);
  }
}
