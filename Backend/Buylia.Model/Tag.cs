﻿namespace Buylia.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Product>? Products { get; set; }
    }
}