using BasicClient;

var client = new StarWarsClient();
var filmsResponse = await client.GetFilms();
var films = filmsResponse.Data;
foreach (var film in films)
{
    Console.WriteLine($"{film.ReleaseDate} {film.Title}");
}
