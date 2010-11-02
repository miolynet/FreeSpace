using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public class Client<T>
        where T : IBrand, new()
    {
        public void ClientMain()
        {
            IFactory<T> factory = new Factory<T>();
        }
    }
}
