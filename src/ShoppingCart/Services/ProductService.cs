using ShoppingCart.Models;
using ShoppingCart.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>()
        {
            new Product() { Code = "A", DiscountPrice = 7.00M, DiscountQuantity = 4, Price = 2.00M },
            new Product() { Code = "B", Price = 12.00M },
            new Product() { Code = "C", DiscountPrice = 6.00M, DiscountQuantity = 6, Price = 1.25M },
            new Product() { Code = "D", Price = 0.15M }
        };

        public Product FindProduct(string code)
        {
            return products.SingleOrDefault(p => p.Code == code);
        }
    }
}
