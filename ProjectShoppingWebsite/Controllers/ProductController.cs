using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectShoppingWebsite.DataAccessLayer;
using ProjectShoppingWebsite.Models;
using ProjectShoppingWebsite.Repository;

namespace ProjectShoppingWebsite.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductRepository repo;
        public ProductController(IProductRepository repository)
        {
            repo = repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           return Ok(repo.GetAllProducts());
        }

        [HttpPost]
        public Product CreateProduct(Product product)
        {
            return repo.AddProduct(product);
        }

        [HttpPut]
        public IActionResult UpdateProductById(int id,Product product)
        {
            return Ok(repo.UpdateProduct(id, product));
        }

        [HttpDelete]
        public IActionResult DeleteProductById(int id)
        {
            return Ok(repo.DeleteProduct(id));
        }
        [HttpGet]
        public IActionResult SortByIncreasingPrice()
        {
            return Ok(repo.SortingByPrice());
        }
        [HttpGet]
        public IActionResult SortByCategory(string category)
        {
            return Ok(repo.SortingByCategory(category));
        }
       

    }
}
