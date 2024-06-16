using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class ProductAttribute
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Key { get; set; } = string.Empty;
    [Required]
    [MaxLength(200)]
    public string Value { get; set; } = string.Empty;

    public int ProductId { get; set; }
    public Product? Product { get; set; }
}
