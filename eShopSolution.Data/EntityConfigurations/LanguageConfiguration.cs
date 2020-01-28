using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            // Set table name
            builder.ToTable("Languages");

            // Set primary key
            builder.HasKey(x => x.Id);

            // Set id is required, non unicode, maxlength is 5
            builder.Property(x => x.Id)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(5);

            // Set name is required & maxlength is 20
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
