using Microsoft.EntityFrameworkCore;
using TransmitterApi.Domain.Models.Schema;

namespace TransmitterApi.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 1500
                },
                new Product
                {
                    Id = 2,
                    Name = "Charger",
                    Price = 60
                },
                new Product
                {
                    Id = 3,
                    Name = "Display",
                    Price = 300
                }
            );
        }
    }
}
