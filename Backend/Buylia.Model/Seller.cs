namespace Buylia.Models;

public class Seller : User
{
    public string? ShopName { get; set; }
    public string? ShopDescription { get; set; }
    public string? ShopImage { get; set; }

    public virtual ICollection<Product>? Products { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
}
