using Buylia.Model.Enums;

namespace Buylia.Model;

public class Admin : User
{
    public UserRole Role { get; set; }
}
