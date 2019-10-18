using Microsoft.EntityFrameworkCore;
using SimpleAPI.Domain.Models;

namespace SimpleAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Athlete> Athletes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Sport>().ToTable("Sports");
            builder.Entity<Sport>().HasKey(p => p.Id);
            builder.Entity<Sport>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Sport>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Sport>().HasMany(p => p.Athletes).WithOne(p => p.Sport).HasForeignKey(p => p.SportId);

            builder.Entity<Sport>().HasData
            (
                new Sport { Id = 100, Name = "Baseball" }, // Id set manually due to in-memory provider
                new Sport { Id = 101, Name = "Football" }
            );

            builder.Entity<Athlete>().ToTable("Athletes");
            builder.Entity<Athlete>().HasKey(p => p.Id);
            builder.Entity<Athlete>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Athlete>().Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Entity<Athlete>().Property(p => p.FirstName).HasMaxLength(50);
            builder.Entity<Athlete>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Athlete>().Property(p => p.UnitOfMeasurement).IsRequired();
            builder.Entity<Athlete>().Property(p => p.Number).IsRequired();
            builder.Entity<Athlete>().Property(p => p.HallOfFameInductee);
            builder.Entity<Athlete>().Property(p => p.Alive);
        }
    }
}