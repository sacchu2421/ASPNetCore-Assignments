using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Address { get; set; }

        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
