#include "mock.hpp"

_Serial Serial;

_Serial::_Serial() : in(""), out("") {}

char _Serial::read() {
  char ch;
  in.get(ch);
  return ch;
}

void _Serial::print(const char *str) {
  if (!out.good()) {
    out.clear();
    out.str("");
  }

  out << str;
}

void _Serial::begin(int baudRate) { }

int _Serial::available() {
  return in.peek() == EOF ? 0 : 1;
}
