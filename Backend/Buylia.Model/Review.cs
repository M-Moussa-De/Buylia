using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class Review
{
    public int Id { get; set; }
    [Required] // Dependes on the Bus req. Could be optional
    [MaxLength(1000)]
    public string Content { get; set; } = string.Empty;
    [Range(0, 5)]
    public float Rating { get; set; }
    public DateTime CreatedAt { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }

    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}