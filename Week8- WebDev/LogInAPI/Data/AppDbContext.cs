using Microsoft.EntityFrameworkCore;

namespace LogInAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){}
}