using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
       // PK
       builder.HasKey(o => o.Id);

        // TotalPrice
        builder.Property(o => o.TotalPrice)
            .IsRequired();

        // Status
        builder.Property(o => o.Status)
            .IsRequired()
            .HasMaxLength(50);

        // OrderedAt
        builder.Property(o => o.OrderedAt)
            .IsRequired();

        // ArrivedOn
        builder.Property(o => o.ArrivedOn)
            .IsRequired();

        // Navigation Customer
        builder.HasOne(o => o.Customer)
            .WithMany(cu => cu.Orders)
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        // Navigation Seller
        builder.HasOne(o => o.Seller)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.SellerId)
            .OnDelete(DeleteBehavior.Restrict);

        // Navigation OrderItems
        builder.HasMany(o => o.OrderItems)
            .WithOne(oi => oi.Order)
            .HasForeignKey(oi => oi.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        // Navigation Payment
        builder.HasOne(o => o.Payment)
            .WithOne(p => p.Order)
            .HasForeignKey<Payment>(p => p.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
