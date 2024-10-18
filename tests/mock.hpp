#ifndef TESTS_MOCK_HPP
#define TESTS_MOCK_HPP

#include <sstream>
#include <string>

#define pinOutput(...)
#define digitalWrite(...)
#define delay(...)
#define pinMode(...)

constexpr auto LOW = 0;
constexpr auto HIGH = 1;
constexpr auto OUTPUT = 0;

class Test;

class _Serial {
  std::stringstream in;
  std::stringstream out;

public:
  friend Test;

  _Serial();

  char read();

  void print(const char*);
  
  void begin(int baudRate);

  int available();
};

extern _Serial Serial;

#endif // !TESTS_MOCK_HPP
