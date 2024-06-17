namespace Buylia.Model;

public class Localization
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public string Language { get; set; } = string.Empty;

    public int? ProductId { get; set; }
    public virtual Product? Product { get; set; }

    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
