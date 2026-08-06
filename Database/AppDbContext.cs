using FUT18Launcher.Models;
using Microsoft.EntityFrameworkCore;

namespace FUT18Launcher.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Club> Clubs => Set<Club>();

    public DbSet<Player> Players => Set<Player>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Player>()
    .HasOne(p => p.Club)
    .WithMany(c => c.Players)
    .HasForeignKey(p => p.ClubId)
    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name)
                  .IsRequired()
                  .HasMaxLength(64);
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Name)
                  .IsRequired()
                  .HasMaxLength(64);
        });
    }
}
