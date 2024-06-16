namespace Buylia.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
    public string? Image { get; set; }
    public string? Brand { get; set; }
    public float Rating { get; set; }

    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }

    public int SellerId { get; set; }
    public virtual Seller? Seller { get; set; }

    public virtual ICollection<Review>? Reviews { get; set; }
    public virtual ICollection<Tag>? Tags { get; set; }
    public virtual ICollection<ProductAttributes>? ExtraAttributes { get; set; }
    public virtual ICollection<Localization<Product>>? Localization { get; set; }
}