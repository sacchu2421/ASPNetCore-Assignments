using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Product
    {
        [Key]

        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductCategory { get; set; }

        [Required]
        public int Productprice { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductImage { get; set; }

    }
}
