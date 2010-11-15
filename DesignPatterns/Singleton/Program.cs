using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Singleton.Singleton;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singleton = SingletonClass.GetInstance();
            Console.WriteLine(singleton.MembersAccess);
        }
    }
}
