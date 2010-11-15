using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer.Observer;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer.Observer observer1 = new Observer.Observer(subject,"01");
            Observer.Observer observer2 = new Observer.Observer(subject,"02");

            subject.Go();
        }
    }
}
