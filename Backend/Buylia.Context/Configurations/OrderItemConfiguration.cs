using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        // PK
        builder.HasKey(oi => oi.Id);

        // Quantity
        builder.Property(oi => oi.Quantity)
            .IsRequired();

        // Navigation Product
        // builder.HasOne(oi => oi.Product)

        // FK Order
        builder.HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
