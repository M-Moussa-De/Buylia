using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // PK
        builder.HasKey(c => c.CategoryId);

        // Name
        builder.Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(100);
        
        // Description
        builder.Property(c => c.Description)
               .HasMaxLength(250);

        // Image
        builder.Property(c => c.Image)
               .HasMaxLength(500);

        // Configure the self-referencing relationship
        builder.HasOne(ca => ca.ParentCategory)
               .WithMany(sub => sub.SubCategories)
               .HasForeignKey(ca => ca.ParentCategoryId)
               .OnDelete(DeleteBehavior.Restrict);  // Prevent Cascading Delete

        // Configure the relationship with Products
        builder.HasMany(c => c.Products)
               .WithOne(p => p.Category)
               .HasForeignKey(p => p.CategoryId);

        // Collection Localization
        builder.HasMany(p => p.Localization)
               .WithOne(l => l.Category)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}