using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Command
{
    public interface ICommand <T>
        where T : new()
    {
        void Execute(T obj);
    }
}
