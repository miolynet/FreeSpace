using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Observer
{
    public class Subject
    {
        public delegate void Callback(string msg);
        public event Callback Notify;


        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify(value);
            }
        }

        public void Go()
        {
            State = "Subject call 'Go()' method to Change state.";
        }
    }
}
