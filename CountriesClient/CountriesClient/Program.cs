using CountriesClient;

var client = new CountriesClient.CountriesClient();
IEnumerable<Country> countries;

Console.WriteLine("All:");
countries = await client.Get();
Print(countries);

Console.WriteLine($"{Environment.NewLine}Latvian:");
countries = await client.GetByLanguage("Latvian");
Print(countries);

Console.WriteLine($"{Environment.NewLine}Riga:");
countries = await client.GetByCapital("Riga");
Print(countries);

static void Print(IEnumerable<Country> countries)
{
    foreach (var country in countries.Take(2))
    {
        Console.WriteLine(
            $"{country.name.common} {country.region} {string.Join(" ", country.capital ?? new List<string>())}"
        );
    }
}
