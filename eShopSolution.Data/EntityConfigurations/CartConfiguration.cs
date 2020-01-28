using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            // Set table name
            builder.ToTable("Carts");

            // Set primary key
            builder.HasKey(x => x.Id);

            // Set auto increment for id
            builder.Property(x => x.Id).UseIdentityColumn();

            // Set foreign key
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
