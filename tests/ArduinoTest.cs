using System.IO.Ports;

namespace tests
{
    internal abstract class ArduinoTest(string port, int baudRate) : Test<string>
    {
        readonly SerialPort _port = new SerialPort(port, baudRate, Parity.None, 8, StopBits.One);

        public void Open()
        {
            _port.Open();
        }

        public void Close()
        {
            _port.Close();
        }

        protected void SendMessage(string message)
        {
            _port.Write($"{message}\n");
        }

        protected string ReceiveMessage()
        {
            return _port.ReadTo("\n");
        }
    }
}
