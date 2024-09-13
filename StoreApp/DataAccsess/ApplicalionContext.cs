using Microsoft.EntityFrameworkCore;
using StoreApp.DataAccsess;
using StoreApp.Models;

public class ApplicationContext : DbContext
{

    public DbSet<Box> Boxes { get; set; } = null!;
    public DbSet<Pallet> Pallets { get; set; } = null!;
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionInfo.ConnectionString);
    }
}

