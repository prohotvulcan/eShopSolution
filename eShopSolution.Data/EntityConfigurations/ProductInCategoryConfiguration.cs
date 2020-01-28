using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            // Set table name
            builder.ToTable("ProductInCategories");

            // Set primary key
            builder.HasKey(x => new { x.CaterogyId, x.ProductId });

            // Set foreign key
            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductInCategories)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.ProductInCategories)
                .HasForeignKey(x => x.CaterogyId);
        }
    }
}
