using InventoryMangementSystemEntities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InventoryMangementSystem.Models
{
    public class MyDbContext : IdentityDbContext<AppUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seeding roles to AspNetRoles table
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole { Id = "540fa4db-060f-4f1b-b60a-dd199bfe4111", Name = "Staff", NormalizedName = "STAFF" }
            );

            // A hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<AppUser>();

            // Seeding users to AspNetUsers table
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4ac66", // primary key
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    EmailConfirmed = true
                },
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4a111", // primary key
                    UserName = "staff",
                    NormalizedUserName = "STAFF",
                    Email = "staff@staff.com",
                    NormalizedEmail = "STAFF@STAFF.COM",
                    PasswordHash = hasher.HashPassword(null, "Staff@123"),
                    EmailConfirmed = true
                }
            );

            // Seeding the relation between our user and role to AspNetUserRoles table
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", // Administrator role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4ac66"  // Admin user
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111", // Staff role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4a111"  // Staff user
                }
                ,
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111", // Staff role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4ac66"  // Admin user
                }

            );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<StockLevel> StockLevels { get; set; }
    }
   
}
