using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMoviesClient
{
    public class StarWarsClient : BaseHttpClient
    {
        public StarWarsClient()
            : base("https://swapi.dev/api/") { }

        public async Task<ApiResult<IEnumerable<Film>>> GetFilms()
        {
            var request = CreateGetRequest("films");
            var films = await SendGetManyRequest<Film>(request);

            return films;
        }
    }
}
