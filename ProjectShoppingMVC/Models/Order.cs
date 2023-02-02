namespace ProjectShoppingMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Product Products { get; set; }

        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
}
