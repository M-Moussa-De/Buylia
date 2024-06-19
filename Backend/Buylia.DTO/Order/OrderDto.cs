using Buylia.Model.Enums;

namespace Buylia.DTO.Order;

public class OrderDto
{
    public double TotalPrice { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime OrderedAt { get; set; }
    public DateTime ArrivedOn { get; set; }
}
