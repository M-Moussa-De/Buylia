namespace Buylia.Models;

public abstract class User
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? ProfileImage { get; set; }
}