using System.ComponentModel.DataAnnotations;

namespace Buylia.Model;

public abstract class User
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Firstname { get; set; } = string.Empty;
    [Required]
    [MaxLength(100)]
    public string Lastname { get; set; } = string.Empty;
    public string? ProfileImage { get; set; }
}