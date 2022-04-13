using Bouwmarkt.Models;
using Microsoft.EntityFrameworkCore;

namespace Bouwmarkt.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


    public DbSet<Vestiging> Vestigingen { get; set; }
    //public DbSet<Koopzondag> Koopzondagen { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vestiging>().HasKey(x => x.VestigingsNummer);
        base.OnModelCreating(modelBuilder);
    }
}
