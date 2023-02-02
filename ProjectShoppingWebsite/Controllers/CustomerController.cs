using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectShoppingWebsite.Models;
using ProjectShoppingWebsite.Repository;

namespace ProjectShoppingWebsite.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerRepository repository;

        public CustomerController(ICustomerRepository repo)
        {
            repository = repo;
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return Ok(repository.GetAllCustomer());
        }
        [HttpDelete]
        public IActionResult DeleteCustomerById(int id)
        {
            return Ok(repository.DeleteCustomer(id));
        }
        [HttpPut]
        public IActionResult UpdateCustomerById(int id, Customer customer)
        {
            return Ok(repository.UpdateCustomer(id, customer));
        }
        [HttpGet]
        public IActionResult GetCustomerById(int id)
        {
            return Ok(repository.GetCustomerById(id));
        }
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            return Ok(repository.AddCustomer(customer));
        }
    }
    }
