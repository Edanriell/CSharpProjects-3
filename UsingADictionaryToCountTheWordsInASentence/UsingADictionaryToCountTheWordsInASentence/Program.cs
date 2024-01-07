class Program
{
    public static void Main()
    {
        string input;
        do
        {
            Console.Write("Enter a phrase:");
            input = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(input))
            {
                var countsByWord = WordCounter.Process(input);
                var i = 0;
                //deconstruction
                foreach (var (key, value) in countsByWord)
                {
                    Console.Write($"{key.PadLeft(20)}={value}\t");
                    i++;
                    if (i % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        } while (input != string.Empty);
    }
}
