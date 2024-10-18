#ifndef TESTS_TEST_HPP
#define TESTS_TEST_HPP

#include <functional>
#include <string>

class Test {
  std::function<void()> _pass = []() {};
  std::function<void()> _fail = []() {};
  bool _is_finished = false;

protected:
  void complete(bool passed);

  void put__serial_in(const std::string& input);
  char read__serial_out();
  bool isempty__serial_out();
  bool iseof__serial_out();

public:
  virtual void setup() = 0;
  virtual void check() = 0;

  virtual ~Test() = default;

  bool is_finished() const;

  void on_pass(const std::function<void()>& callback);
  void on_fail(const std::function<void()> &callback);
};

#endif // !TESTS_TEST_HPP
