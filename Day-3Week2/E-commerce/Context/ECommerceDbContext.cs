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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            //seed category
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Sports" },
                new Category { Id = 2, Name = "Electronics" },
                new Category { Id = 3, Name = "cloths" },
            };

            modelBuilder.Entity<Category>().HasData(categories);

            var products = new List<Product>
            {
                new Product { Id = 10, Name = "Badminton", Price = 457, CategoryId = 1 },
                new Product { Id = 11, Name = "Mouse", Price = 100, CategoryId = 2 },
                new Product { Id = 12, Name = "Suit", Price = 230, CategoryId = 3 },
                new Product { Id = 13, Name = "One-piece", Price = 436, CategoryId = 3 },
                new Product { Id = 14, Name = "Earphones", Price = 200, CategoryId = 2 },
                new Product { Id = 15, Name = "Cricket", Price = 500, CategoryId = 1 },
            };

            modelBuilder.Entity<Product>().HasData(products);

            base.OnModelCreating(modelBuilder);
        }
    }
}
