using InventoryMangementSystemEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryMangementSystem.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<StockLevel> StockLevels { get; set; }
    }
   
}
