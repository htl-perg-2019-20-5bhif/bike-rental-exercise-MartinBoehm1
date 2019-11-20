using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Model
{
    public enum Gender
    {
        Male,
        Female,
        Unknown,
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [StringLength (50)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(75)]
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "date")]
        [Required]
        public DateTime Birthday { get; set; }
        [StringLength(75)]
        [Required]
        public string Street { get; set; }
        [StringLength(10)]
        public string HouseNumber { get; set; }
        [StringLength(10)]
        [Required]
        public string ZipCode { get; set; }
        [StringLength(75)]
        [Required]
        public string Town { get; set; }

        public LinkedList<Rental> Rentals { get; set; }


    }
}
