using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.FactoryMethod
{
    public class Creator
    {
        public IProduct FactoryMethod(int amount)
        {
            IProduct product;
            if (amount % 2 == 0) product = new ProductA();
            else product = new ProductB();

            return product;
        }
    }
}
