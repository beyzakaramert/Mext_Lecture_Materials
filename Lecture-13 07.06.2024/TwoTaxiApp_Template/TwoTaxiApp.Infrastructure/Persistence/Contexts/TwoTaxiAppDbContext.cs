using Microsoft.EntityFrameworkCore;
using TwoTaxiApp.Domain;

namespace TwoTaxiApp.Infrastructure;

public class TwoTaxiAppDbContext : DbContext
{
    public DbSet<Passenger> Passangers { get; set; }
    public DbSet<TaxiDriver> TaxiDrivers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=TaxiAppDb;User Id=postgres;Password=mysecretpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasDiscriminator<string>("discriminator")
            .HasValue<Passenger>("passenger")
            .HasValue<TaxiDriver>("taxi_driver");
    }
}
