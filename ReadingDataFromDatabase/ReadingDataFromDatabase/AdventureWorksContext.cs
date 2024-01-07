using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReadingDataFromDatabase
{
    public class AdventureWorksContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public AdventureWorksContext()
            : base(UsePostgreSqlServerOptions()) { }

        protected static DbContextOptions UsePostgreSqlServerOptions()
        {
            return new DbContextOptionsBuilder()
                .UseNpgsql(
                    "Host=localhost;Username=postgres;Password=1234;Database=Adventureworks;"
                )
                .Options;
        }

        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options)
            : base(options) { }
    }
}
