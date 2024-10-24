using System.IO.Ports;

namespace client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializePortsList();
            InitializeBaudRatesList();
        }

        private void InitializePortsList()
        {
            var portNames = SerialPort.GetPortNames().ToList();
            this.PortSelect.DataSource = portNames;
        }

        private void InitializeBaudRatesList()
        {
            List<int> baudRates = [300, 600, 750, 1200,
                2400, 4800, 9600, 19200, 31250, 38400,
                57600, 74880, 115200, 230400, 250000,
                460800,  500000, 921600, 1000000, 2000000];

            this.BaudRateSelect.DataSource = baudRates;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.InputField.Text))
            {
                MessageBox.Show("Input must not be empty");
                return;
            }

            try
            {
                using var serialPort = new SerialPort(PortSelect.Text, int.Parse(BaudRateSelect.Text), Parity.None, 8, StopBits.One);
                serialPort.Open();
                serialPort.DiscardInBuffer();
                var message = InputField.Text + '\n';

                OutputLog.Text = (OutputLog.Text ?? string.Empty) + $"[{DateTime.Now}] - [SENT]: {message}{Environment.NewLine}";

                serialPort.WriteLine(message);
                message = serialPort.ReadLine();

                OutputLog.Text = (OutputLog.Text ?? string.Empty) + $"[{DateTime.Now}] - [RECEIVED]: {message}{Environment.NewLine}";
            }
            catch { }
        }
    }
}
