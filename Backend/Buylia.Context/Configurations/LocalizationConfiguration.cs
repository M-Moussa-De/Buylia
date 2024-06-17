using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class LocalizationConfiguration : IEntityTypeConfiguration<Localization>
{
    public void Configure(EntityTypeBuilder<Localization> builder)
    {
        // PK
        builder.HasKey(l => l.Id);

        // Name
        builder.Property(l => l.Name)
            .HasMaxLength(100);

        // Description
        builder.Property(l => l.Description)
            .HasMaxLength(500);

        // Language
        builder.Property(l => l.Language)
            .IsRequired()
            .HasMaxLength(10);

        // FK Product
        builder.HasOne(l => l.Product)
            .WithMany(p => p!.Localization)
            .HasForeignKey(l => l.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        // FK Category
        builder.HasOne(l => l.Category)
            .WithMany(c => c!.Localization)
            .HasForeignKey(l => l.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
