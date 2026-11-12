using Microsoft.EntityFrameworkCore;
using EstateFlow.Application;
using EstateFlow.Domain;

namespace EstateFlow.Infrastructure.Data;

public class EstateFlowDbContext : DbContext, IApplicationDbContext
{
    public DbSet<City> Cities => Set<City>();
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<PropertyImage> PropertyImages => Set<PropertyImage>();
    public DbSet<Meter> Meters => Set<Meter>();
    public DbSet<UtilityType> UtilityTypes => Set<UtilityType>();
    public DbSet<Provider> Providers => Set<Provider>();
    public DbSet<MeterReading> MeterReadings => Set<MeterReading>();
    public DbSet<Tenant> Tenants => Set<Tenant>();
    public DbSet<Rental> Rentals => Set<Rental>();
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<Contract> Contracts => Set<Contract>();
    public DbSet<Expense> Expenses => Set<Expense>();
    public DbSet<Payment> Payments => Set<Payment>();

    public EstateFlowDbContext(DbContextOptions<EstateFlowDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}