using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdEntityFramework.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private Product[] GetProducts()
        {
            return new Product[]
            {
                new Product { Id = 1,Name="TShirt",Description="Red",Price=1998,Unit=5},
                new Product { Id = 2,Name="TShirt",Description="White",Price=500,Unit=5},
                new Product { Id = 3,Name="Shirt",Description="Formal Shirt",Price=100,Unit=5}
            };
        }
    }
}
