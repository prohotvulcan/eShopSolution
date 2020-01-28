using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            // Set table name
            builder.ToTable("ProductTranslations");

            // Set primary key
            builder.HasKey(x => x.Id);

            // Set auto increment for id
            builder.Property(x => x.Id).UseIdentityColumn();

            // Set name is required & maxlength is 200
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Set seo alias is required & maxlength is 200
            builder.Property(x => x.SeoAlias)
                .IsRequired()
                .HasMaxLength(200);

            // Set detail maxlength is 500
            builder.Property(x => x.Details).HasMaxLength(500);

            // Set language id is reuired, non unicode, maxlength is 5
            builder.Property(x => x.LanguageId)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(5);

            // Set foreign key
            builder.HasOne(x => x.Language)
                .WithMany(x => x.ProductTranslations)
                .HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductTraslations)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
