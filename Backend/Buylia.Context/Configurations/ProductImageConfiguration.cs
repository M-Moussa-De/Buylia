using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> builder)
    {
        // PK
        builder.HasKey(e => e.Id);

        // Url
        builder.Property(e => e.Url)
               .IsRequired()
               .HasMaxLength(500);

        // Navigation Product
        builder.HasOne(pi => pi.Product)
               .WithMany(p => p!.Images)
               .HasForeignKey(pi => pi.ProductId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
