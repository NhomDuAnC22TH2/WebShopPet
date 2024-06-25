using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace WebShopPet.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //seed data to table Categories<>
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Bull", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Alaska", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Husky", DisplayOrder = 3 },
            new Category { Id = 4, Name = "Chihuahua", DisplayOrder = 4});
            //seed data to table Product<>
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Bull Anh", Price = 300, CategoryId = 1 },
            new Product { Id = 2, Name = "Bull Pháp", Price = 350, CategoryId = 1 },
            new Product { Id = 3, Name = "American Bully", Price = 400, CategoryId = 1 },
            new Product { Id = 4, Name = "American Pit Bull Terrier", Price = 420, CategoryId = 1 },
            new Product { Id = 5, Name = "Alaska Sable – trắng", Price = 630, CategoryId = 2 },
            new Product { Id = 6, Name = "Alaska màu lông xám – trắng", Price = 750, CategoryId = 2 },
            new Product { Id = 7, Name = "Alaska màu lông nâu đỏ – trắng", Price = 820, CategoryId = 2 },
            new Product { Id = 8, Name = "Husky màu đen trắng", Price = 950, CategoryId = 3 },
            new Product { Id = 9, Name = "Husky màu xám", Price = 1200, CategoryId = 3 },
            new Product { Id = 10, Name = "Husky màu trắng tinh khiết ", Price = 1450, CategoryId = 3 },
            new Product { Id = 11, Name = "Husky màu đồng hoặc đỏ", Price = 750, CategoryId = 3 },
            new Product { Id = 12, Name = "Chihuahua Socola", Price = 1250, CategoryId = 4 });
        }
    }
}
