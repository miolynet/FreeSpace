using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public class Poochy :IBrand
    {
        public int Price
        {
            get { return 300; }
        }

        public string Material
        {
            get { return "Plastic."; }
        }
    }
}
