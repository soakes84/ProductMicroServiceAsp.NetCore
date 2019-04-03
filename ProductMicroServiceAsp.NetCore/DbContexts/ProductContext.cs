using Microsoft.EntityFrameworkCore;
using ProductMicroServiceAsp.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroServiceAsp.NetCore.DbContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Description = "Reading Material",
                },
                new Category
                {
                    Id = 2,
                    Name = "Outdoors",
                    Description = "Hiking equipment and accessories",
                },
                new Category
                {
                    Id = 3,
                    Name = "Chickens",
                    Description = "Everything you need for raising chickens",
                },
                 new Category
                 {
                     Id = 4,
                     Name = "Sports",
                     Description = "All Sports",
                 }
            );
        }
    }
}
