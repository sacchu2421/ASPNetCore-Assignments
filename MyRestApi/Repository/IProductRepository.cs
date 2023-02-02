using Microsoft.EntityFrameworkCore;
using MyRestApi.Models;

namespace MyRestApi.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        public Product Add(Product product);
        public bool Update(Product product);

        public bool Remove(int id);
    }
}
