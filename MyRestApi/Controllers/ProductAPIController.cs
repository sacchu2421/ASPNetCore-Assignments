using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRestApi.Models;
using MyRestApi.Repository;

namespace MyRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly IProductRepository _repository;



        public ProductAPIController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {



            return Ok(_repository.GetAllProducts());



        }



        [HttpPost]



        public IActionResult Create([FromBody] Product product)
        {



            var createdProduct = _repository.Add(product);
            return CreatedAtRoute("GetProduct", new { id = createdProduct.ToString() }, createdProduct);



        }
        [HttpGet("{id}", Name = "GetProduct")]



        public IActionResult GetProduct(int id)



        {



            Product item = _repository.GetProduct(id);



            if (item == null)



            {



                NotFound();



            }



            return Ok(item);



        }         //[HttpGet("{category}", Name = "GetProductByCategory")]



        //public IActionResult GetProductsByCategory(string category)



        //{



        //    return (IActionResult)Ok(_repository.GetAll().Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase)));



        //}



        [HttpPut("{id}")]



        public IActionResult Update(int id, [FromBody] Product product)



        {



            product.Id = id;



            if (!_repository.Update(product))



            {



                NotFound();



            }



            return Ok(_repository.Update(product));



        }



        [HttpDelete("{id}")]



        public IActionResult Delete(int id)



        {



            _repository.Remove(id);



            return NoContent();



        }
    }
}
