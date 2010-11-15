using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.Command;

namespace Command.ObjectReference
{
    public class SwitchOnLampCommand : ICommand<Lamp>
    {
        #region ICommand<Lamp> Members

        public void Execute(Lamp obj)
        {
            obj.SwitchOn();
        }

        #endregion
    }
}
