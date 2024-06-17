using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        // PK
        builder.HasKey(r => r.Id);

        // Content
        builder.Property(r => r.Content)
              // Dependes on the Bus. req. It might be optional
              .IsRequired()
              .HasMaxLength(1000);

        // Rating
        builder.Property(r => r.Rating)
              .HasPrecision(3, 1);

        // CreatedAt
        //builder.Property(r => r.CreatedAt)
        //       .IsRequired();

        // Navigation Customer
        builder.HasOne(r => r.Customer)
               .WithMany(c => c.Reviews)
               .HasForeignKey(r => r.CustomerId)
               .OnDelete(DeleteBehavior.Restrict);

        // Navigation Product
        builder.HasOne(r => r.Product)
               .WithMany(p => p.Reviews)
               .HasForeignKey(r => r.ProductId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
