using System.ComponentModel.DataAnnotations;

namespace Project_Website.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
