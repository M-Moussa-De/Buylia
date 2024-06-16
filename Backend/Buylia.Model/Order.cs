using Buylia.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class Order
{
    public int Id { get; set; }
    public double TotalPrice { get; set; }
    [MaxLength(50)]
    public OrderStatus Status { get; set; }
    public DateTime OrderedAt { get; set; }
    public DateTime ArrivedOn { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }

    public int SellerId { get; set; }
    public virtual Seller? Seller { get; set; }

    public virtual ICollection<OrderItem>? OrderItems { get; set; }

    public virtual Payment? Payment { get; set; }
}