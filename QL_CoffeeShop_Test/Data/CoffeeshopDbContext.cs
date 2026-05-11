using QL_CoffeeShop_Test.Models;
using Microsoft.EntityFrameworkCore;
namespace QL_CoffeeShop_Test.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "America", Price = 25, detail = "Name product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp" }, new Product { Id = 2, Name = "Vietnam", Price = 20, detail = "Vietnamese product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee1024x536.webp" },
           new Product { Id = 3, Name = "United Kingdom", Price = 15, detail = "UK product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee1024x536.webp" },
            new Product { Id = 4, Name = "India", Price = 15, detail = "India product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp" }, new Product { Id = 5, Name = "Russian", Price = 25, detail = "Russian product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee1024x536.webp" },
            new Product { Id = 6, Name = "France", Price = 35, detail    = "France product", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee1024x536.webp" }
            );
        }
    }
}
