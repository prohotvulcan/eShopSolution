using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class CaterogyTranslationConfiguration 
        : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            // Set table name
            builder.ToTable("CategoryTranslations");

            // Set primary key
            builder.HasKey(x => x.Id);

            // Set auto increment for id
            builder.Property(x => x.Id).UseIdentityColumn();

            // Set Name is required & maxlength is 200
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            // Set SeoAlias is required & maxlength is 200
            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            // Set SeoDescription maxlength is 500
            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            // Set SeoTitle maxlength is 200
            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            // Set LanguageId is required, non unicode, maxlength is 5
            builder.Property(x => x.LanguageId)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(5);

            // Set CategoryTranslations language foreign key
            builder.HasOne(x => x.Language)
                .WithMany(x => x.CategoryTranslations)
                .HasForeignKey(x => x.LanguageId);

            // Set CategoryTranslations foreign key
            builder.HasOne(x => x.Category)
                .WithMany(x => x.CategoryTranslations)
                .HasForeignKey(x => x.CaterogyId);
        }
    }
}
