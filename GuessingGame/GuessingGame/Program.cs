int numberToBeGuessed = new Random().Next(0, 10);
int remainingChances = 5;
bool numberFound = false;

Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("Guess a random number between 0 and 10.");
Console.WriteLine($"You have {remainingChances} chances to guess the number.");

while (remainingChances > 0 && !numberFound)
{
    Console.Write("Enter a number: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        remainingChances--;

        if (number == numberToBeGuessed)
        {
            Console.WriteLine(
                $"Congratulations! You guessed the number with {remainingChances} chances left."
            );
            numberFound = true;
            return;
        }
        else
        {
            if (remainingChances > 0)
            {
                Console.WriteLine("Sorry, wrong guess. Please try again.");
                Console.WriteLine($"You still have {remainingChances} chances to guess a number.");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

Console.WriteLine($"You're out of chances. The number was {numberToBeGuessed}.");


/*var numberToBeGuessed = new Random().Next(0, 10);

var remainingChances = 5;

var numberFound = false;

Console.WriteLine("Welcome to Packt's C# Workshop Guessing Game.");

while (remainingChances > 0 && !numberFound)
{
    Console.WriteLine($"\n You have {remainingChances} chances. Please type a number between 0 and 10 to try to guess the number generated for you.");

    var number = int.Parse(Console.ReadLine());

    if (number == numberToBeGuessed)
    {
        numberFound = true;
    }
    else
    {
        remainingChances--;
    }
}

if (numberFound)
{
    Console.WriteLine($"Congrats! You've guessed the number correctly with {remainingChances} chances left.");
}
else
{
    Console.WriteLine($"You're out of chances. The number was {numberToBeGuessed}.");
}*/
