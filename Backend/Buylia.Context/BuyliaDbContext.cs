using Buylia.Model;
using Microsoft.EntityFrameworkCore;

namespace Buylia.Context;

public class BuyliaDbContext(DbContextOptions<BuyliaDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //builder.Entity<User>()
        //    .HasNoKey();
    }
}
