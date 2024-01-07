using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAGenericRepository
{
    public class ProductPriceHistory : IAggregate
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfPrice { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
