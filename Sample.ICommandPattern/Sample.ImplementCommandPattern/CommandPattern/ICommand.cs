using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.ImplementCommandPattern.CommandPattern
{
    public interface ICommand <T>
    {
        void Execute(T obj);
    }
}
