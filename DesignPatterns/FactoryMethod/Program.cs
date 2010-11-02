using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod.FactoryMethod;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new Creator();
            
            IProduct product;
            for (int amount = 0; amount <= 10; amount++)
            {
                product = creator.FactoryMethod(amount);
                Console.WriteLine(product.ShipFrom());
            }
        }
    }
}
