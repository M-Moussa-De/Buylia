namespace Buylia.Application.Shared;

public class EntityQueryParameters
{
    public string? Filter { get; set; }
    public int? Page { get; set; }
    public int PageSize { get; set; } = 10;
    public string? SortBy { get; set; }
    public bool Ascending { get; set; } = true;
}