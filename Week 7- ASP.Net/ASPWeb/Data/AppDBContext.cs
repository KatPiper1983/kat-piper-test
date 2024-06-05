using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreExample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to one relationship
            modelBuilder.Entity<User>()
                    .HasOne(u => u.Profile)
                    .WithOne(p => p.User)
                    .HasForeignKey<Profile>(p => p.UserId);

            // One-to-many relationship
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        }
    }

}
