using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
{
    public void Configure(EntityTypeBuilder<ProductAttribute> builder)
    {
        // PK
        builder.HasKey(pa => pa.Id);

        // Key
        builder.Property(pa => pa.Key)
            .IsRequired()
            .HasMaxLength(100);

        // Value
        builder.Property(pa => pa.Value)
            .IsRequired()
            .HasMaxLength(200);

        // Navigation Product
        builder.HasOne(pa => pa.Product)
            .WithMany(p => p!.ProductAttributes)
            .HasForeignKey(pa => pa.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}