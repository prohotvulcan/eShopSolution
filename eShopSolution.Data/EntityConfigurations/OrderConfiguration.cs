using eShopSolution.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace eShopSolution.Data.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Set table name
            builder.ToTable("Orders");

            // Set primary key
            builder.HasKey(x => x.Id);

            // Set auto increment for id
            builder.Property(x => x.Id).UseIdentityColumn();

            // Set order date is default today
            builder.Property(x => x.OrderDate).HasDefaultValue(DateTime.Today);

            // Set ship email is required & maxlength is 200
            builder.Property(x => x.ShipEmail)
                .IsRequired()
                .HasMaxLength(200);

            // Set ship address is required & maxlength is 200
            builder.Property(x => x.ShipAddress)
                .IsRequired()
                .HasMaxLength(200);

            // Set ship name is required & maxlength is 200
            builder.Property(x => x.ShipName)
                .IsRequired()
                .HasMaxLength(200);

            // Set ship phone number is required & maxlength is 20
            builder.Property(x => x.ShipPhoneNumber)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
