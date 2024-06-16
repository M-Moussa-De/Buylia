using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class Localization
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    [Required]
    [MaxLength(10)]
    public string Language { get; set; } = string.Empty;

    public int? ProductId { get; set; }
    public virtual Product? Product { get; set; }

    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
