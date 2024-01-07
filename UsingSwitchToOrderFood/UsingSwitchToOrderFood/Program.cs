var menuBuilder = new System.Text.StringBuilder();

menuBuilder.AppendLine("Welcome to the Burger Joint. ");
menuBuilder.AppendLine(string.Empty);
menuBuilder.AppendLine("1) Burgers and Fries - 5 USD");
menuBuilder.AppendLine("2) Cheeseburger - 7 USD");
menuBuilder.AppendLine("3) Double-cheeseburger - 9 USD");
menuBuilder.AppendLine("4) Coke - 2 USD");
menuBuilder.AppendLine(string.Empty);
menuBuilder.AppendLine("Note that every burger option comes with fries and ketchup!");

WriteLine(menuBuilder.ToString());

WriteLine("Please type one of the following options to order:");

var option = ReadKey();

switch (option.KeyChar.ToString())
{
    case "1":
    {
        WriteLine("\nAlright, some burgers on the go. Please pay the cashier.");
        break;
    }
    case "2":
    {
        WriteLine("\nThank you for ordering cheeseburgers. Please pay the cashier.");
        break;
    }
    case "3":
    {
        WriteLine(
            "\nThank you for ordering double cheeseburgers, hope you enjoy them. Please pay the cashier!"
        );
        break;
    }
    case "4":
    {
        WriteLine("\nThank you for ordering Coke. Please pay the cashier.");
        break;
    }
    default:
    {
        WriteLine("\nSorry, you chose an invalid option.");
        break;
    }
}
