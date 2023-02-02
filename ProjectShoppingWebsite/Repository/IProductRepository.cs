using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public interface IProductRepository
    {
      public IEnumerable<Product> GetAllProducts();
      public Product AddProduct(Product product);
      public bool UpdateProduct(int id ,Product product);
      public bool DeleteProduct(int id);
      public IEnumerable<Product> SortingByPrice();
      public IEnumerable<Product> SortingByCategory(string category);
    

    }
}
