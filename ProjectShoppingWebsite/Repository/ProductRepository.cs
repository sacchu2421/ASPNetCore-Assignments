﻿using ProjectShoppingWebsite.DataAccessLayer;
using ProjectShoppingWebsite.Models;

namespace ProjectShoppingWebsite.Repository
{
    public class ProductRepository : IProductRepository
    {
        public readonly ShoppingContext ShoppingContext;
        public ProductRepository(ShoppingContext con)
        {
            ShoppingContext = con;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return ShoppingContext.Products;
        }

        public Product AddProduct(Product product )
        {
            Product productCopy = new Product();

            productCopy.ProductImage = product.ProductImage;
            productCopy.ProductName = product.ProductName;
            productCopy.ProductDescription = product.ProductDescription;
            productCopy.Productprice = product.Productprice;
            productCopy.ProductCategory = product.ProductCategory;
             ShoppingContext.Add(productCopy);
            ShoppingContext.SaveChanges();
            return productCopy;
             
        }
        public bool UpdateProduct(int id, Product product)
        {
            Product pro = ShoppingContext.Products.Find(id);
            pro.Productprice = product.Productprice;
            pro.ProductName = product.ProductName;
            pro.ProductDescription = product.ProductDescription;
            pro.ProductImage = product.ProductImage;
            pro.ProductCategory = product.ProductCategory;
            ShoppingContext.Products.Update(pro);
            ShoppingContext.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product product = ShoppingContext.Products.Find(id);
            ShoppingContext.Products.Remove(product);
            ShoppingContext.SaveChanges();
            return true;
        }

        public IEnumerable<Product> SortingByPrice()
        {
            var query = (from product in ShoppingContext.Products
                         orderby product.Productprice ascending
                         select product).ToList();
            return query;
        }
        public IEnumerable<Product> SortingByCategory(string category)
        {
            var query = (from product in ShoppingContext.Products
                         where product.ProductCategory == category
                         select product).ToList();

            return query;
        }
                  

    }
}
