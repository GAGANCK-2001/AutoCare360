using AutoCare360.Domain.Customers;
using AutoCare360.Domain.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace AutoCare360.Infrastructure.Persistence;

public sealed class AutoCare360DbContext : DbContext
{
    public AutoCare360DbContext(DbContextOptions<AutoCare360DbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutoCare360DbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
