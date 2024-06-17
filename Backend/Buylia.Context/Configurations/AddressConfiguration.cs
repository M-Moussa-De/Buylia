using Buylia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buylia.Context.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        // PK
        builder.HasKey(p => p.Id);

        // Street
        builder.Property(a => a.Street)
               .HasMaxLength(100);
        
        // HouseNr
        builder.Property(a => a.HouseNr)
               .HasMaxLength(10);
      
        // City
        builder.Property(a => a.City)
               .HasMaxLength(100);
        
        // Country
        builder.Property(a => a.Country)
               .HasMaxLength(100);
    }
}
