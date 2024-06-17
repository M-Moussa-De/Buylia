using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // PK
        builder.HasKey(p => p.Id);

        // Name
        builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(100);

        // Description
        builder.Property(p => p.Description)
               .HasMaxLength(500);

        // Price
        builder.Property(p => p.Price)
               .HasPrecision(10, 2);

        // Stock
        builder.Property(p => p.Stock)
               .HasMaxLength(int.MinValue);

        // Image
        builder.Property(p => p.Image)
            .HasMaxLength(500);

        // Brand
        builder.Property(p => p.Brand)
            .HasMaxLength(100);

        // Rating
        builder.Property(p => p.Rating)
            .HasPrecision(3, 1);

        // Navigation Category
        builder.HasOne(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

        // Navigation Seller
        builder.HasOne(p => p.Seller)
               .WithMany(s => s.Products)
               .HasForeignKey(p => p.SellerId)
               .OnDelete(DeleteBehavior.Restrict);

        // Collection Reviews
        builder.HasMany(p => p.Reviews)
               .WithOne(r => r.Product)
               .HasForeignKey(r => r.ProductId)
               .OnDelete(DeleteBehavior.Cascade);

        // Collection Tags
        builder.HasMany(p => p.Tags)
               .WithMany(t => t.Products)
               .OnDelete(DeleteBehavior.Cascade);

        // Collection Colors
        builder.HasMany(p => p.Colors)
               .WithOne(c => c.Product)
               .OnDelete(DeleteBehavior.Cascade);

        // Collection Images
        builder.HasMany(p => p.Images)
               .WithOne(i => i.Product)
               .OnDelete(DeleteBehavior.Cascade);

        // Collection Sizes
        builder.HasMany(p => p.Sizes)
               .WithOne(s => s.Product)
               .OnDelete(DeleteBehavior.Cascade);

        // Collection ProductAttributes
        builder.HasMany(p => p.ProductAttributes)
               .WithOne(pa => pa.Product)
               .OnDelete(DeleteBehavior.Cascade);

        // Collection Localization
        builder.HasMany(p => p.Localization)
               .WithOne(l => l.Product)
               .OnDelete(DeleteBehavior.Cascade);


    }
}
