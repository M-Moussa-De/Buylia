namespace Buylia.Models;

public class Payment
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int OrderId { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
    public decimal Amount { get; set; }
    public string? PaymentMethod { get; set; }
}
