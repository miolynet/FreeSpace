using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.ICommandPattern.CommandPattern
{
    public class DecreaseSpeedCommand : ICommand
    {
        public void Execute(Fan fan)
        {
            fan.DecreaseSpeed();
        }
    }
}
