namespace ProjectShoppingMVC.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

  
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
            [ForeignKey("CartId")]
            public int CartId { get; set; }


        }
    }


