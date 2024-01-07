using AssigningAndInvokingDelegates;
using System.Globalization;

var random = new Random();
string input;

do
{
    Console.Write("Yesterday's distance: ");
    input = Console.ReadLine()!;
    double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out var distanceYesterday);

    var carYesterday = new Car
    {
        Distance = distanceYesterday,
        JourneyTime = random.NextDouble() * 10D
    };

    Console.Write("    Today's distance: ");
    input = Console.ReadLine()!;
    double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out var distanceToday);

    var carToday = new Car { Distance = distanceToday, JourneyTime = random.NextDouble() * 10D };

    var comparer = new JourneyComparer();
    comparer.Compare(carYesterday, carToday);

    Console.WriteLine();
    Console.WriteLine("Journey Details   Distance\tTime\tAvg Speed");
    Console.WriteLine("-------------------------------------------------");

    Console.Write($"Yesterday         {comparer.Distance.Yesterday:N0}   \t");
    Console.WriteLine($"{comparer.JourneyTime.Yesterday:N0}\t{comparer.AverageSpeed.Yesterday:N0}");

    Console.Write($"Today             {comparer.Distance.Today:N0}     \t");
    Console.WriteLine($"{comparer.JourneyTime.Today:N0}\t{comparer.AverageSpeed.Today:N0}");

    Console.WriteLine("=================================================");
    Console.Write($"Difference        {comparer.Distance.Difference:N0}     \t");
    Console.WriteLine(
        $"{comparer.JourneyTime.Difference:N0}\t{comparer.AverageSpeed.Difference:N0}"
    );
    Console.WriteLine("=================================================");
} while (!string.IsNullOrEmpty(input));
