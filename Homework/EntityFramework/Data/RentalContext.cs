using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class RentalContext:DbContext
    {
        public RentalContext(DbContextOptions<RentalContext> options)
        : base(options)
        { }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Rental> Rentals { get; set; }

        /*protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Rental>()
                .Property(r=>r.RentalEnd)
                .
        }*/
    }
}
