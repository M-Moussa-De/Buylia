namespace Buylia.DTO.Review;

public class ReviewDto
{
    public string Content { get; set; } = string.Empty;
    public float Rating { get; set; }
    public DateTime CreatedAt { get; set; }
}
