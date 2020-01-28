using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            // Set table name
            builder.ToTable("AppConfigs");

            // Set primary key
            builder.HasKey(x => x.Key);

            // Set Value is required
            builder.Property(x => x.Value).IsRequired();
        }
    }
}
