using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.ImplementCommandPattern
{
    public class Fan
    {
        private const int MaxSpeed = 3;
        private const int MinSpeed = 0;

        public bool IsPowerOn { get; private set; }
        public int Speed { get; private set; }

        public void TogglePower()
        {
            if (IsPowerOn) Console.WriteLine("The fan is now OFF");
            else Console.WriteLine("The fan is now ON");
            IsPowerOn = !IsPowerOn;
        }

        public void IncreaseSpeed()
        {
            if (IsPowerOn && (Speed < MaxSpeed)) {
                Speed++;
                Console.WriteLine("The fan level: {0}", Speed);
            }
        }

        public void DecreaseSpeed()
        {
            if (IsPowerOn && (Speed > MinSpeed)) {
                Speed--;
                Console.WriteLine("The fan level: {0}", Speed);
            }
        }
    }
}
