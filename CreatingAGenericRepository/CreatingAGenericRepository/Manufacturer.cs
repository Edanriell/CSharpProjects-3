using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace CreatingAGenericRepository
{
    public partial class Manufacturer : IAggregate
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FoundedAt { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
