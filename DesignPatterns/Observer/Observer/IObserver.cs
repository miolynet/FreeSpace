using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Observer
{
    public interface IObserver
    {
        void Update(string state);
    }
}
