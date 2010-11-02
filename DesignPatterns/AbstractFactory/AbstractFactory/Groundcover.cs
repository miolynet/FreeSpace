using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public class Groundcover :IBrand
    {
        public int Price
        {
            get { return 2000; }
        }

        public string Material
        {
            get { return "South african leather."; }
        }
    }
}
