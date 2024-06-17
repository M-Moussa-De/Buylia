using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
       // PK
       builder.HasKey(t => t.Id);

        // Name
        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(100);

        // Collection Products
        builder.HasMany(t => t.Products)
               .WithMany(p => p!.Tags)
               .UsingEntity(j => j.ToTable("ProductTags"));

    }
}
