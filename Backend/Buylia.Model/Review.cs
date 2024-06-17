namespace Buylia.Model;

public class Review
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public float Rating { get; set; }
    public DateTime CreatedAt { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }

    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}