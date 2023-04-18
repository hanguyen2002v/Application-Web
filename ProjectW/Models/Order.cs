namespace ProjectW.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string? Title { get; set; }
        public int QuantityBook { get; set; }
        public float PriceBook { get; set; }
        public float TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
