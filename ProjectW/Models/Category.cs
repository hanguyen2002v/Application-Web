namespace ProjectW.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<Book>? Book { get; set; }
    }
}
