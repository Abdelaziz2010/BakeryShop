using BakeryShop.Data.Configurations;
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Data
{
    public class BakeryShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=BakeryDB;Integrated Security=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}
