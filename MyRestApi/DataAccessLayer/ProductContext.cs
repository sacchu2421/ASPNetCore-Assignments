using Microsoft.EntityFrameworkCore; 
    using MyRestApi.Models;

namespace MyRestApi.DataAccessLayer
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
