using tests;

string port = "COM7";
int baudRate = 115200;

for (int x = 0; x < args.Length; x++)
{
    if (args[x] == "-p")
    {
        if (args.Length > x + 1)
        { port = args[x + 1]; }
        else
        { PrintUsage(); return; }
    }
    else if (args[x].StartsWith("--port="))
    { port = args[x].Split('=').Last(); }
    else if (args[x] == "-b")
    {
        if (args.Length > x + 1)
        { baudRate = int.Parse(args[x + 1]); }
        else
        { PrintUsage(); return; }
    }
    else if (args[x].StartsWith("--baud="))
    { baudRate = int.Parse(args[x].Split('=').Last()); }
    else { PrintUsage(); return; };
}

List<ArduinoTest> tests = [new TestHello(port, baudRate), new TestGoodBye(port, baudRate)];
int passed = 0;
Console.WriteLine("Running tests...");
foreach (ArduinoTest test in tests)
{
    if (test.Run().Check()) passed++;
}
Console.WriteLine($"Tests finished: {passed}/{tests.Count} passed");

static void PrintUsage()
{
    Console.WriteLine(
        $"{AppDomain.CurrentDomain.FriendlyName} [(-p <port>) | (--port=<port>)] [(-b <baud-rate>) | (--baud=<baud-rate>)]\n" +
        "  -p, --port=     Sets COM port. Default is COM7\n" +
        "  -b, --baud=     Sets Baud Rate. Default is 115200");
}

class TestHello(string port, int baudRate) : ArduinoTest(port, baudRate)
{
    public override TestResult<string> Run()
    {
        Open();
        SendMessage("Hello");
        var res =  new TestResult<string>(ReceiveMessage().Trim())
            .Expect("Ifmmp")
            .OnPass((val) =>
            {
                Console.WriteLine($"[{this.GetType().Name}]: PASS ({val})");
            })
            .OnFail((val) =>
            {
                Console.WriteLine($"[{this.GetType().Name}]: FAIL ({val})");
            });
        Close();
        return res;
    }
}

class TestGoodBye(string port, int baudRate) : ArduinoTest(port, baudRate)
{
    public override TestResult<string> Run()
    {
        Open();
        SendMessage("Good bye");
        var res = new TestResult<string>(ReceiveMessage().Trim())
            .Expect("Hppe czf")
            .OnPass((val) =>
            {
                Console.WriteLine($"[{this.GetType().Name}]: PASS ({val})");
            })
            .OnFail((val) =>
            {
                Console.WriteLine($"[{this.GetType().Name}]: FAIL ({val})");
            });
        Close();
        return res;
    }
}