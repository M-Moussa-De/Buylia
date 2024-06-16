using System.ComponentModel.DataAnnotations;

namespace Buylia.Model
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Product>? Products { get; set; }
    }
}