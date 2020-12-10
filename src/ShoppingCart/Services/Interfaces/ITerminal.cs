using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Interfaces
{
    public interface ITerminal
    {
        void Scan(string item);
        decimal Total();
    }
}
