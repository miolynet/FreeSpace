using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Command
{
    public class CommandInvoker <T>
        where T : new()
    {
        public void InvokeAll(IEnumerable<ICommand<T>> commands, T obj)
        {
            Console.WriteLine("[Command invoke execute]");
            foreach (var cmd in commands) cmd.Execute(obj);
        }
    }
}
