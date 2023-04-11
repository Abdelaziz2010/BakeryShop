
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakeryShop.Data.Configurations
{
    //IEntityTypeConfiguration:-
    //Allows configuration for an entity type to be factored into a separate class,
    //rather than in-line in OnModelCreating(ModelBuilder).

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        //Configures the entity.
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(m => m.ImageName).HasColumnName("ImageFileName");
            builder.Property(p => p.Price).HasColumnType("decimal(18,1)");
        }
    }
}
