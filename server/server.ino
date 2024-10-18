#define LED_BUILTIN 8

char buff[256];
int c = 0;

void blink(uint32_t times = 1, uint32_t ontime = 100, uint32_t offtime = 100) {
  for (uint32_t x = 0; x < times; x++) {
    digitalWrite(LED_BUILTIN, LOW);
    delay(ontime);
    digitalWrite(LED_BUILTIN, HIGH);
    if (times - x > 1) delay(offtime);   
  }
}

void setup() {
  Serial.begin(115200);
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, HIGH);
  blink(3, 300);
}

void loop() {
  if (Serial.available() > 0) {
    buff[c] = Serial.read();

    if (!c && (buff[c] == '\n' || buff[c] == '\r')) return;

    if (buff[c] == '\n') {
      buff[c + 1] = 0;
      for (char *cc = buff; *cc; cc++) {
        if ((*cc >= 97 && *cc <= 122) || (*cc >= 65 && *cc <= 90)) (*cc)++;
        if (*cc == 123 || *cc == 91) *cc -= 26;
      }

      Serial.print(buff);

      c = 0;
      blink(1, 2000);
    } else {
      c = (c + 1) % 255;
    }
  }
}
