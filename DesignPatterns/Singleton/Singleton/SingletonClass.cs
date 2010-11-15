using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton.Singleton
{
    public class SingletonClass
    {
        private static SingletonClass _instance;
        public string MembersAccess {
            get
            {
                return "From singleton class message.";
            }
        }

        // Another accessibility (protected or private )
        protected SingletonClass() { }

        public static SingletonClass GetInstance(){
            if (_instance == null) _instance = new SingletonClass();
            return _instance;
        }
    }
}
