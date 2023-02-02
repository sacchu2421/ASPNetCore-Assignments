using Microsoft.EntityFrameworkCore;
using MyRestApi.DataAccessLayer;
using MyRestApi.Models;

namespace MyRestApi.Repository
{
    public class ProductRepository:IProductRepository
    {
        private readonly ProductContext _context;



        public ProductRepository(ProductContext context)
        {
            _context = context;
        }



        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }



        public bool Remove(int id)
        {
            var p = GetProduct(id);

            _context.Products.Remove(p);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Product product)
        {
            var p = GetProduct(product.Id);
            p.Price = product.Price;
            p.Name = product.Name;
            p.Description = product.Description;
            _context.SaveChanges();
            return true;
        }


    }
}
    

