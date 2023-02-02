using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Website.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public List<Product> Products { get; set; }

        public int Quantity { get; set; }
     
    }
}
