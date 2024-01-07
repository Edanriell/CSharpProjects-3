using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrackingSystemForTrucksDispatched
{
    public class TruckDispatchDbContext : DbContext
    {
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<TruckDispatch> TruckDispatches { get; set; }

        public TruckDispatchDbContext()
            : base(UsePostgreSqlServerOptions()) { }

        protected static DbContextOptions UsePostgreSqlServerOptions()
        {
            return new DbContextOptionsBuilder().UseNpgsql("connection_string").Options;
        }

        public TruckDispatchDbContext(DbContextOptions<TruckDispatchDbContext> options)
            : base(options) { }
    }
}
