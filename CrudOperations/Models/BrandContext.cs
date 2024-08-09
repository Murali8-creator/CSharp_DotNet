using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Users)
                .WithOne(b => b.Brand)
                .HasForeignKey(u => u.DeviceId);
        }

    }
}
