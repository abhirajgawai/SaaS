using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        this.Database.SetCommandTimeout(180);
    }

    #region dbo
    public DbSet<EntityProduct> Products { get; set; }
    public DbSet<EntityCategory> Category { get; set; }
    public DbSet<EntityBillboard> Billboard { get; set; }
    public DbSet<EntitySize> Sizes { get; set; }
    public DbSet<EntityColors> Color { get; set; }
    public DbSet<EntityOrder> Order { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<EntityProduct>()
            .HasOne(p => p.Category)
            .WithMany() // Assuming no navigation property in EntityCategory
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.NoAction)

        modelBuilder.Entity<EntityProduct>()
            .HasOne(p => p.Billboard)
            .WithMany() // Assuming no navigation property in EntityBillboard
            .HasForeignKey(p => p.BillboardId)
            .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.NoAction)

        modelBuilder.Entity<EntityProduct>()
            .HasOne(p => p.Size)
            .WithMany() // Assuming no navigation property in EntitySize
            .HasForeignKey(p => p.SizeId)
            .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.NoAction)

        modelBuilder.Entity<EntityProduct>()
            .HasOne(p => p.Color)
            .WithMany() // Assuming no navigation property in EntityColors
            .HasForeignKey(p => p.ColorId)
            .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.NoAction)
    }
}