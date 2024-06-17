using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class ProductSizeConfiguration : IEntityTypeConfiguration<ProductSize>
{
    public void Configure(EntityTypeBuilder<ProductSize> builder)
    {
        // PK
        builder.HasKey(ps => ps.Id);

        // Size
        builder.Property(ps => ps.Size)
            .IsRequired()
            .HasPrecision(3, 1);

        // Navigation Product
        builder.HasOne(ps => ps.Product)
            .WithMany(p => p!.Sizes)
            .HasForeignKey(ps => ps.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}