using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public interface IBrand
    {
        int Price { get; }
        string Material { get; }
    }
}
