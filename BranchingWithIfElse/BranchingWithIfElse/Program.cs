WriteLine("Please type a username. It must have at least 6 characters: ");

var username = ReadLine();

if (username!.Length < 6)
{
    WriteLine($"The username {username} is not valid.");
}
else
{
    WriteLine(
        "Now type a password. It must have a length of at least 6 characters and also contain a number."
    );

    var password = ReadLine();

    if (password!.Length < 6)
    {
        WriteLine("The password must have at least 6 characters.");
    }
    else if (!password.Any(c => char.IsDigit(c)))
    {
        WriteLine("The password must contain at least one number.");
    }
    else
    {
        WriteLine("User successfully registered.");
    }
}
