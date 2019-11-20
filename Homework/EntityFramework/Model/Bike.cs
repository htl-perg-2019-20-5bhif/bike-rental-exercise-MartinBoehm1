using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Model
{
    public enum BikeCategory
    {
        Standardbike,
        Mountainbike,
        Treckingbike,
        Racingbike
    }
    public class Bike
    {
        public int BikeId { get; set; }
        [StringLength(25)]
        [Required]
        public string Brand { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime PurchaseDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfLastService { get; set; }
        [Required]
        [Range (0, double.MaxValue)]
        [Column(TypeName = "decimal(18, 2)")]
        public double RentalRateInEuroForFirstHour { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18, 2)")]
        public double RentalRateInEuroForEachAdditionalHour { get; set; }
        [Required]
        public BikeCategory Category { get; set; }

    }
}
