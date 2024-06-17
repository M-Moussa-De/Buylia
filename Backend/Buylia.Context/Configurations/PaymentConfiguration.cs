using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        // PK
        builder.HasKey(p => p.Id);

        // Amount
        builder.Property(p => p.Amount)
               .IsRequired();

        // Response
        builder.Property(p => p.Response)
               .IsRequired()
               .HasMaxLength(100);

        // Navigation Order
        builder.HasOne(p => p.Order)
               .WithOne(o => o.Payment)
               .HasForeignKey<Payment>(p => p.OrderId);
    }
}