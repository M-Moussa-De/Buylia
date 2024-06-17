namespace Buylia.Model;

public abstract class User
{
    public int Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string? ProfileImage { get; set; }
}