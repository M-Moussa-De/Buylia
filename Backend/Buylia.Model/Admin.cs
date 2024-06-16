using Buylia.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public class Admin : User
{
    [Required]
    public UserRole Role { get; set; }
}
