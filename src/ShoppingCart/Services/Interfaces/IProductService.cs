using ShoppingCart.Models;

namespace ShoppingCart.Services.Interfaces
{
    public interface IProductService
    {
        Product FindProduct(string code);
    }
}
