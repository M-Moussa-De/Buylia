using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class ProductColor
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Color { get; set; } = string.Empty;

    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}
