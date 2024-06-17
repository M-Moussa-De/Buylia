namespace Buylia.Model;

public class ProductSize
{
    public int Id { get; set; }
    public float Size { get; set; }

    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}