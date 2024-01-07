using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystemForTrucksDispatched
{
    [Table("Truck", Schema = "TruckLogistics")]
    public class Truck
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Brand { get; set; }

        [MaxLength(100)]
        public string Model { get; set; }
        public int YearOfMaking { get; set; }
    }
}
