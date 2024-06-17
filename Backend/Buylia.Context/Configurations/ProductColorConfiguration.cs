using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class ProductColorConfiguration : IEntityTypeConfiguration<ProductColor>
{
    public void Configure(EntityTypeBuilder<ProductColor> builder)
    {
        // PK
        builder.HasKey(pc => pc.Id);

        // Color
        builder.Property(pc => pc.Color)
            .IsRequired()
            .HasMaxLength(50);

       // Navigation Product
        builder.HasOne(pc => pc.Product)
            .WithMany(p => p!.Colors)
            .HasForeignKey(pc => pc.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
