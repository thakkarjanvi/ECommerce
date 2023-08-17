using Day_3Week2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Day_3Week2.E_commerce.Context
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Configure your database provider and connection string here
        //    optionsBuilder.UseSqlServer("YourConnectionStringHere");
        //}
    }
}
