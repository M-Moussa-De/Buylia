﻿namespace Buylia.Model;

public class Payment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Response { get; set; } = string.Empty;

    public int OrderId { get; set; }
    public virtual Order? Order { get; set; }
}
