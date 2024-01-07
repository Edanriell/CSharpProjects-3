using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMoviesClient
{
    public record ApiResult<T>
    {
        public int Count { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        public T Results { get; set; }
    }
}
