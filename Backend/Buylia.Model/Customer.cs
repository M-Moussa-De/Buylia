namespace Buylia.Model;

public class Customer : User
{
    public DateTime DateOfBirth { get; set; }
    
    public virtual ICollection<Address>? Address { get; set; }

    public virtual ICollection<Cart>? Carts { get; set; }
    
    public virtual ICollection<Order>? Orders { get; set; }
    
    public virtual ICollection<Review>? Reviews { get; set; }
}
