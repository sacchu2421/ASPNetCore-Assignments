using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectShoppingWebsite.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        
        
       
   

        
    }
}
