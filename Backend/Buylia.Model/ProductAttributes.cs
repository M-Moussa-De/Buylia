namespace Buylia.Models;

public class ProductAttributes
{
    public string? Color { get; set; }
    public string? Size { get; set; }
    public string? Image { get; set; }

    public int ProductId { get; set; }
    public Product? Product { get; set; }
}
