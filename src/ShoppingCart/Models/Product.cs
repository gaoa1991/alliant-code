using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class Product
    {
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int? DiscountQuantity { get; set; }
        public decimal? DiscountPrice { get; set; }
    }
}
