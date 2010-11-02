using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.FactoryMethod
{
    public class ProductB : IProduct
    {
        public string ShipFrom()
        {
            return "From Japan.";
        }
    }
}
