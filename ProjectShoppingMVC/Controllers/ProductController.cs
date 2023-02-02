using Microsoft.AspNetCore.Mvc;
using ProjectShoppingMVC.Models;
using ProjectShoppingMVC.ViewModel;
using System.Collections.Generic;
using System.Net.Http;
namespace ProjectShoppingMVC.Controllers
{
    public class ProductController : Controller
    {
        HttpClient client;
        HttpResponseMessage response;
        ProductViewModel pvm = new ProductViewModel();
       List<Product> products1 = new List<Product>();
        public IActionResult Index()
        {
          return View();
        }
      
        public IActionResult GetAllProducts()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5106/");
            response = client.GetAsync("api/Product/GetAll/").Result;
            var products = response.Content.ReadFromJsonAsync<IEnumerable<Product>>().Result;
            foreach (var p in products)
            {
                Product prod = new Product();
                prod.ProductId = p.ProductId;
                prod.ProductName = p.ProductName;
                prod.Productprice = p.Productprice;
                prod.ProductImage = p.ProductImage;
                prod.ProductDescription = p.ProductDescription;
                prod.ProductCategory = p.ProductCategory;
                products1.Add(prod);
            }
            pvm.products = products1;
            return View(pvm);
        

    }
    }
}
