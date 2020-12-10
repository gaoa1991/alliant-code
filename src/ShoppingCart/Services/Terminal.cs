using ShoppingCart.Models;
using ShoppingCart.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Services
{
    public class Terminal : ITerminal
    {
        private readonly IProductService ProductService;
        private decimal SubTotal = 0;
        private readonly Dictionary<Product, int> DiscountTracker = new Dictionary<Product, int>();

        public Terminal(IProductService productService)
        {
            ProductService = productService;
        }
        public void Scan(string item)
        {
            var prod = ProductService.FindProduct(item);

            if (prod.DiscountQuantity.HasValue)
            {
                if (DiscountTracker.ContainsKey(prod))
                {
                    var count = DiscountTracker[prod];
                    DiscountTracker[prod]++;
                    if (prod.DiscountQuantity == count + 1)
                    {
                        SubTotal += prod.DiscountPrice.Value;
                        DiscountTracker.Remove(prod);
                    }
                }
                else
                {
                    DiscountTracker.Add(prod, 1);
                }
            }
            else
            {
                SubTotal += prod.Price;
            }
        }

        public decimal Total()
        {
            return SubTotal + DiscountTracker.Keys.Sum(p => DiscountTracker[p] * p.Price);
        }
    }
}
