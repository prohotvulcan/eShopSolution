using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.EntityConfigurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            // Set table name
            builder.ToTable("Contacts");

            // Set primary key
            builder.HasKey(x => x.Id);

            // Set auto increment for id
            builder.Property(x => x.Id).UseIdentityColumn();

            // Set name is required & maxlength is 200
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Set email is required & maxlength is 200
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(200);

            // Set phone number is required & maxlength is 20
            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            // Set message is required
            builder.Property(x => x.Message).IsRequired();
        }
    }
}
