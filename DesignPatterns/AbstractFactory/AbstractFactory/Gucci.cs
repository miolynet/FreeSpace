using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public class Gucci :IBrand
    {
        public int Price
        {
            get { return 1000; }
        }

        public string Material
        {
            get { return "Crocodile skin."; }
        }
    }
}
