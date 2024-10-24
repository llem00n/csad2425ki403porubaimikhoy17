#include "test.hpp"
#include "mock.hpp"


void Test::complete(bool passed) {
  _is_finished = true;
  if (passed) {
    _pass();
  }
  else {
    _fail();
  }
}

void Test::put__serial_in(const std::string& input) {
  Serial.in << input;
}

char Test::read__serial_out() {
  char ch;
  Serial.out.get(ch);
  return ch;
}

bool Test::isempty__serial_out() {
  return Serial.out.str().empty();
}

bool Test::iseof__serial_out() {
  return Serial.out.peek() == EOF;
}

bool Test::is_finished() const {
  return _is_finished;
}

void Test::on_pass(const std::function<void()>& callback) {
  _pass = callback;
}

void Test::on_fail(const std::function<void()>& callback) {
  _fail = callback;
}
