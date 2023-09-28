
namespace AuthApi.Data;

// Data/DataContext.cs
using Microsoft.EntityFrameworkCore;
using AuthApi.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}

