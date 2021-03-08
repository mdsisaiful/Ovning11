using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;
using Storage.Models.ViewModels;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        // Properties
        public DbSet<Storage.Models.Product> Product { get; set; }

        // Constructor
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        //Override method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // run base first then we can change 

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronic",
                    Count = 78,
                    Description = "A portable computer",
                    Orderdate = DateTime.Now.AddDays(-3),
                    Price = 15600,
                    Shelf = "4B"
                }, 
                new Product
                {
                    Id = 2,
                    Name = "IPAD",
                    Category = "Apple",
                    Count = 110,
                    Description = "A tablet",
                    Orderdate = DateTime.Now.AddDays(-6),
                    Price = 8000,
                    Shelf = "5D"
                }
                );
        }

        //Override method
        //public DbSet<Storage.Models.ViewModels.ProductViewModel> ProductViewModel { get; set; }

    }
}
