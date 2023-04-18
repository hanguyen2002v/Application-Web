namespace ProjectW.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int QuantityBook { get; set; }
        public float PriceBook { get; set; }
        public float TotalPrice { get; set; }
    }
}
