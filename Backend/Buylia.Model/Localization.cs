namespace Buylia.Models;

public class Localization<T> where T : class
{
    public int Id { get; set; }
    public string? NameArabic { get; set; }
    public string? DescriptionArabic { get; set; }

    public int ObjectId { get; set; }
    public T? ObjectName { get; set; }
}
