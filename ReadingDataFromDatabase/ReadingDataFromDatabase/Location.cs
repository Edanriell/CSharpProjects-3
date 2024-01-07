using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingDataFromDatabase
{
    [Table("location", Schema = "production")]
    public class Location
    {
        [Column("locationid")]
        public int LocationId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("costrate")]
        public double Costrate { get; set; }

        [Column("availability")]
        public double Availability { get; set; }

        [Column("modifieddate")]
        public DateTime ModifiedDate { get; set; }
    }
}
