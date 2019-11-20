using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Model
{
    public class Rental
    {
        public int RentalId { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Bike Bike { get; set; }
        [Required]
        public DateTime RentalBegin { get; set; }

        public DateTime RentalEnd { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double TotalCost { get; set; }
        public Boolean Paid { get; set; }

    }
}
