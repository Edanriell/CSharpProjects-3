using InvokingAMulticastDelegate;

public static class Program
{
    private const string OutputFile = "activity.txt";

    public static void Main()
    {
        if (File.Exists(OutputFile))
        {
            File.Delete(OutputFile);
        }

        Action<string> logger = LogToConsole;
        logger += LogToFile;

        var cashMachine = new CashMachine(logger);

        Console.Write("Enter your PIN:");
        var pin = Console.ReadLine();
        if (string.IsNullOrEmpty(pin))
        {
            Console.WriteLine("No PIN entered");
            return;
        }

        cashMachine.VerifyPin(pin);
        Console.WriteLine();

        Console.Write("Press Enter to show balance");
        Console.ReadLine();

        cashMachine.ShowBalance();

        Console.Write("Press Enter to quit");
        Console.ReadLine();

        static void LogToConsole(string message) => Console.WriteLine(message);

        static void LogToFile(string message) => File.AppendAllText(OutputFile, message);
    }
}
