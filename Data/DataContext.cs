using bandaid.Models;
using Microsoft.EntityFrameworkCore;

namespace bandaid.Data;

public class DataContext : DbContext
{
    
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {}
    public DbSet<User> Users { get; set; }
    public DbSet<Ad> Ads { get; set; }
}