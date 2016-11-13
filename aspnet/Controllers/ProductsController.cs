using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using aspnet.Models;

namespace aspnet.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Tomato", Category = "Groceries", Price = 1 },
            new Product {Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product {Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };
        
        public IEnumerable<Product> PostAllProducts(Product p)
        {
            if (p.Id != 0)
                return null;

            return products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IEnumerable<Product> GetAllProducts(int user_id)
        {
            if (user_id != 0)
                return null;

            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
