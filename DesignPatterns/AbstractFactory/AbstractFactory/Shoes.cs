using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public class Shoes<T> :IShoes
        where T:IShoes,new ()
    {
        private T _brand;

        public Shoes()
        {
            _brand = new T();
        }

        public int Price
        {
            get { return _brand.Price; }
        }
    }
}
