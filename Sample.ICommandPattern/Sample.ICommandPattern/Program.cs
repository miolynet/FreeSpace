using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ICommandPattern.CommandPattern;

namespace Sample.ICommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            normal();
            
            Console.WriteLine();

            usingCommandInvoker();
        }       

        private static void normal()
        {
            Fan fan = new Fan();
            Remote remote = new Remote(fan);

            remote.TogglePower();

            remote.IncreaseSpeed();
            remote.IncreaseSpeed();
            remote.IncreaseSpeed();
            remote.IncreaseSpeed(); // MAX

            remote.DecreaseSpeed();
            remote.DecreaseSpeed();
            remote.DecreaseSpeed();
            remote.DecreaseSpeed(); // MIN
        }

        private static void usingCommandInvoker()
        {
            List<ICommand> commands = new List<ICommand> {
                new TogglePowerCommand(),

                new IncreaseSpeedCommand(),
                new IncreaseSpeedCommand(),
                new IncreaseSpeedCommand(),
                new IncreaseSpeedCommand(), // MAX

                new DecreaseSpeedCommand(),
                new DecreaseSpeedCommand(),
                new DecreaseSpeedCommand(),
                new DecreaseSpeedCommand(), // MIN
            };

            var fan = new Fan();
            var invoker = new CommandInvoker();
            invoker.InvokeAll(commands.ToArray(), fan);
        }
    }
}
