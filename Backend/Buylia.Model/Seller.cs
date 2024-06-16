using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class Seller : User
{
    [Required]
    [MaxLength(100)]
    public string ShopName { get; set; } = string.Empty;
    public string? ShopDescription { get; set; }
    public string? ShopImage { get; set; }

    public virtual ICollection<Product>? Products { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
}
