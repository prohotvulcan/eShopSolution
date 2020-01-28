using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Set table name
            builder.ToTable("Products");

            // Set primary key
            builder.HasKey(x => x.Id);

            // Set auto increment for id
            builder.Property(x => x.Id).UseIdentityColumn();

            // Set price is required
            builder.Property(x => x.Price).IsRequired();

            // Set original price is required
            builder.Property(x => x.OriginalPrice).IsRequired();

            // Set stock is required & default is 0
            builder.Property(x => x.Stock)
                .IsRequired()
                .HasDefaultValue(0);

            // Set view count is required & default is 0
            builder.Property(x => x.ViewCount)
                .IsRequired()
                .HasDefaultValue(0);
        }
    }
}
