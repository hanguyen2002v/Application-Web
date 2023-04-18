using System.ComponentModel.DataAnnotations;

namespace ProjectW.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public string? Quantity { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set;}
        public virtual Category? Category { get; set; }

    }
}
