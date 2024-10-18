﻿#include "mock.hpp"
#include "server.ino"
#include "test.hpp"
#include <list>
#include <iostream>
#include <memory>
#include <string_view>

template <std::string_view Input, std::string_view Output>
class InputOutputTest : public Test {
  std::string buff;

public:
  void setup() override {
    put__serial_in(Input);
  }

  void check() override {
    while (!isempty__serial_out() && !iseof__serial_out()) {
      char c = read__serial_out();
      buff += c;

      if (c == '\n') {
        complete(buff == Output);
      }
    }
  }
};

int main() {
  std::list<std::shared_ptr<Test>> tests = {
    std::make_shared<InputOutputTest<"Hello\n", "Ifmmp\n">>(),
    std::make_shared<InputOutputTest<"Good bye!\n", "Hppe czf!\n">>()
  };

  size_t testc = 1;
  size_t passed = 0;
  size_t total = tests.size();
  auto on_pass = [&]() {
    std::cout << "[TEST " << testc << "]: PASS\n";
    passed++;
    };
  auto on_fail = [&]() {
    std::cout << "[TEST " << testc << "]: FAIL\n";
    };

  std::cout << "Running tests...\n";

  setup();
  tests.front()->setup();
  tests.front()->on_pass(on_pass);
  tests.front()->on_fail(on_fail);
  while (!tests.empty()) {
    loop();

    tests.front()->check();
    if (tests.front()->is_finished()) {
      testc++;
      tests.pop_front();
      if (!tests.empty()) {
        tests.front()->setup();
        tests.front()->on_pass(on_pass);
        tests.front()->on_fail(on_fail);
      }
    }
  }

  std::cout << "Finished running tests. " << passed << "/" << total << " passed\n";

  return 0;
}
