using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        // PK
        builder.HasKey(c => c.Id);

        // Quantity
        // builder.Property(c => c.Quantity)
        //       .IsRequired();

        // Product
        builder.HasOne(c => c.Product)
               .WithMany()
               .HasForeignKey(c => c.ProductId);

        // Customer
        builder.HasOne(ca => ca.Customer)
               .WithMany(cu => cu.Carts)
               .HasForeignKey(ca => ca.CustomerId);
    }
}
