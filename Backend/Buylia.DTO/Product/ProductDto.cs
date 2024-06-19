namespace Buylia.DTO.Product;

public class ProductDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
    public string? Brand { get; set; }
    public float Rating { get; set; }
}