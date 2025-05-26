using Microsoft.EntityFrameworkCore;
using ImagineCars.Data.Dbo;

namespace ImagineCars.Data;

public class ImagineCarsDbContext : DbContext
{
    public ImagineCarsDbContext(DbContextOptions<ImagineCarsDbContext> options) : base(options)
    {}

    public DbSet<Workshop> Workshops { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Workshop>()
            .Property(c => c.Id)
            .ValueGeneratedOnAdd();
    }
}