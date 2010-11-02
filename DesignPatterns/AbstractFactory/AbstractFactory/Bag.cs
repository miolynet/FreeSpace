using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public class Bag<T> : IBag
        where T:IBag,new ()
    {

        private T _brand;

        public Bag()
        {
            _brand = new T();
        }

        public string Material
        {
            get { return _brand.Material; }
        }
    }
}
