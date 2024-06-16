﻿namespace Buylia.Model;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Image { get; set; }

    public int? ParentCategoryId { get; set; }
    public virtual Category? ParentCategory { get; set; }
    public virtual ICollection<Category>? SubCategories { get; set; }

    public virtual ICollection<Product>? Products { get; set; }
}
