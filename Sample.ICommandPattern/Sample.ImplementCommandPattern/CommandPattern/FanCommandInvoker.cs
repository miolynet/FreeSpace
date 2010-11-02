using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.ImplementCommandPattern.CommandPattern
{
    public class FanCommandInvoker
    {
        public void InvokeAll(ICommand<Fan>[] commands, Fan fan)
        {
            foreach (var cmd in commands)
                cmd.Execute(fan);
        }
    }
}
