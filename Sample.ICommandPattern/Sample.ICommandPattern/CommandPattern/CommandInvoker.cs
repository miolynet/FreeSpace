using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.ICommandPattern.CommandPattern
{
    public class CommandInvoker
    {
        public void InvokeAll(ICommand[] commands, Fan fan)
        {
            Console.WriteLine("[Command invoker executing]");
            foreach (var cmd in commands)
                cmd.Execute(fan);
        }
    }
}
