using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystemForTrucksDispatched
{
    [Table("TruckDispatch", Schema = "TruckLogistics")]
    public class TruckDispatch
    {
        public int Id { get; set; }
        public Truck Truck { get; set; }
        public Person Driver { get; set; }
        public int DriverId { get; set; }
        public int TruckId { get; set; }

        [MaxLength(200)]
        public string CurrentLocation { get; set; }
        public DateTime Deadline { get; set; }
    }
}
