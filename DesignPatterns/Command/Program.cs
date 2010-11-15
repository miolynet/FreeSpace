using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.ObjectReference;
using Command.Command;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variable
            Lamp lamp = new Lamp();
            List<ICommand<Lamp>> commands = new List<ICommand<Lamp>>();
            CommandInvoker<Lamp> invoker = new CommandInvoker<Lamp>();

            // initialize call commands
            commands.Add(new SwitchOnLampCommand());
            commands.Add(new SwitchOnLampCommand());
            commands.Add(new SwitchOffLampCommand());
            commands.Add(new SwitchOnLampCommand());
            commands.Add(new SwitchOffLampCommand());
            commands.Add(new SwitchOnLampCommand());

            // call commands from invoker 
            invoker.InvokeAll(commands, lamp);
        }
    }
}
