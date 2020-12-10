using ShoppingCart.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ShoppingCart.Test
{
    public class ShoppingCartTest
    {
        [Theory]
        [InlineData("ABCDABAA", 32.40)]
        [InlineData("CCCCCCC", 7.25)]
        [InlineData("ABCD", 15.40)]
        public void Test1(string data, decimal total)
        {
            var prodService = new ProductService();

            var terminal = new Terminal(prodService);

            List<string> codes = new List<string>(data.Select(c => c.ToString()));

            codes.ForEach((code) => terminal.Scan(code));

            Assert.Equal(total, terminal.Total());
        }
    }
}
