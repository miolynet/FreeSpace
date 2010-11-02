using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ICommandPattern.CommandPattern;

namespace Sample.ICommandPattern
{
    public class Remote
    {
        private Fan _fan;

        public Remote(Fan fan)
        {
            _fan = fan;
        }

        public void TogglePower()
        {
            executeCommand(new TogglePowerCommand());
        }

        public void IncreaseSpeed()
        {
            executeCommand(new IncreaseSpeedCommand());
        }

        public void DecreaseSpeed()
        {
            executeCommand(new DecreaseSpeedCommand());
        }

        private void executeCommand(CommandPattern.ICommand command)
        {
            Console.WriteLine("[Remote executing command]");
            command.Execute(_fan);
        }
    }
}
