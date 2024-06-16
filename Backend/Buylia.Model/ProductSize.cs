using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class ProductSize
{
    public int Id { get; set; }
    [Required]
    [Range(0, float.MaxValue)]
    public float Size { get; set; }

    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}
