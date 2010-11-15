using System;
using System.Linq;
using System.Text;

namespace Observer.Observer
{
    public class Observer : IObserver
    {

        private Subject _subject;
        private string _name;

        public Observer(Subject subject,string name)
        {
            _subject = subject;
            _name = name;
            _subject.Notify += Update;
        }

        #region IObserver Members

        public void Update(string state)
        {
            Console.WriteLine("From observer{1}: {0}",state,_name);
        }

        #endregion
    }
}
