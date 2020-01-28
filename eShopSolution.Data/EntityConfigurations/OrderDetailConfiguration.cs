using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            // Set table name
            builder.ToTable("OrderDetails");

            // Set primary key
            builder.HasKey(x => new { x.OrderId, x.ProductId });

            // Set foreign key
            builder.HasOne(x => x.Product)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
