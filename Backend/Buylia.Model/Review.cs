namespace Buylia.Models;

public class Review
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Product? ProductId { get; set; }
}