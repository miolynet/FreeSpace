using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public interface IFactory<T> where T : IBrand
    {
        IBag CreateBag();
        IShoes CreateShoes();
    }
}
