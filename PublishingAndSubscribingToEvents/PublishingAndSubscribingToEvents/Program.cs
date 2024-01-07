public static class Program
{
    public static void Main()
    {
        var clock = new AlarmClock();
        clock.Ticked += ClockTicked;
        clock.WakeUp += ClockWakeUp;
        clock.ClockTime = DateTime.Now;
        clock.AlarmTime = DateTime.Now.AddMinutes(120);

        Console.WriteLine($"ClockTime={clock.ClockTime:t}");
        Console.WriteLine($"AlarmTime={clock.AlarmTime:t}");
        clock.Start();

        Console.WriteLine("Press ENTER");
        Console.ReadLine();

        static void ClockWakeUp(object sender, EventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Wake up");
        }

        static void ClockTicked(object sender, DateTime e) => Console.Write($"{e:t}...");
    }
}
