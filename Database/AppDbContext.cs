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

        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(64);

            entity.Property(c => c.ManagerName)
                .IsRequired()
                .HasMaxLength(64);

            entity.Property(c => c.Coins)
                .HasDefaultValue(500);

            entity.Property(c => c.Level)
                .HasDefaultValue(1);

            entity.Property(c => c.Experience)
                .HasDefaultValue(0);
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(64);

            entity.Property(p => p.Position)
                .HasMaxLength(10);

            entity.Property(p => p.Nation)
                .HasMaxLength(64);

            entity.Property(p => p.League)
                .HasMaxLength(64);

            entity.Property(p => p.ClubName)
                .HasMaxLength(64);

            entity.Property(p => p.Contract)
                .HasDefaultValue(7);

            entity.Property(p => p.Fitness)
                .HasDefaultValue(99);

            entity.HasOne(p => p.Club)
                .WithMany(c => c.Players)
                .HasForeignKey(p => p.ClubId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
