using UsingAStatementLambdaToReverseWordsInASentence;

public static class Program
{
    public static void Main()
    {
        do
        {
            Console.Write("Enter a sentence:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            var result = WordUtilities.ReverseWords(input);
            Console.WriteLine($"Reversed: {result}");
        } while (true);
    }
}
