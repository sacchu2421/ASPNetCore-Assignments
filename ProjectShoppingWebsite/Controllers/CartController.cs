using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectShoppingWebsite.Models;
using ProjectShoppingWebsite.Repository;

namespace ProjectShoppingWebsite.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public readonly ICartRepository repository;

            public CartController(ICartRepository repo)
        {
            repository = repo;
        }
        [HttpPost]
        public IActionResult AddCart(Cart cart)
        {
            return Ok(repository.AddCart(cart));
        }
        [HttpDelete]
        public IActionResult DeleteCartById(int id)
        {
            return Ok(repository.DeleteCart(id));
        }
        [HttpGet]
        public IActionResult GetCartById(int id)
        {
            return Ok(repository.GetCart(id));
        }
    }
}
