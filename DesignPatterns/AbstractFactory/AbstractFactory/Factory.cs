using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public class Factory<T> : IFactory<T>
        where T : IBrand, new()
    {
        public IBag CreateBag()
        {
            return new Bag<T>();
        }

        public IShoes CreateShoes()
        {
            return new Shoes<T>();
        }
    }
}
