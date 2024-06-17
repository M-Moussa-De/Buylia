namespace Buylia.Model;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
    public string? Brand { get; set; }
    public float Rating { get; set; }

    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }

    public int SellerId { get; set; }
    public virtual Seller? Seller { get; set; }

    public virtual ICollection<Review>? Reviews { get; set; }
    public virtual ICollection<Tag>? Tags { get; set; }
    public virtual ICollection<ProductColor>? Colors { get; set; }
    public virtual ICollection<ProductImage>? Images { get; set; }
    public virtual ICollection<ProductSize>? Sizes { get; set; }
    public virtual ICollection<ProductAttribute>? ProductAttributes { get; set; }
    public virtual ICollection<Localization>? Localization { get; set; }
}