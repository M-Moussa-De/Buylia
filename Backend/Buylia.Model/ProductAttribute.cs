﻿namespace Buylia.Model;

public class ProductAttribute
{
    public int Id { get; set; }
    public string Key { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;

    public int ProductId { get; set; }
    public Product? Product { get; set; }
}
