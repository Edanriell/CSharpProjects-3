using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMoviesClient
{
    public record Film
    {
        public string Title { get; set; }

        public int EpisodeId { get; set; }

        public string OpeningCrawl { get; set; }

        public string Director { get; set; }

        public string Producer { get; set; }

        public string Release_Date { get; set; }

        public string[] Characters { get; set; }

        public string[] Planets { get; set; }

        public string[] Starships { get; set; }

        public string[] Vehicles { get; set; }

        public string[] Species { get; set; }

        public DateTime Created { get; set; }

        public DateTime Edited { get; set; }

        public string Url { get; set; }
    }
}
