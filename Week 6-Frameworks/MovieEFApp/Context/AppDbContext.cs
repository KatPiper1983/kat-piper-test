

using Microsoft.EntityFrameworkCore;


class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Movie> Movies { get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Read in our Connection String from our txt file
        string connectionString = File.ReadAllText(@"C:\Users\U1J482\OneDrive - Government Employees Insurance Company\Desktop\movie-app-db.txt");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasOne(m=> m.Renter).WithMany().HasForeignKey();
    }
}
