using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Facade
{
    public static class Facade
    {
        private static SubSystemA _subSystemA = new SubSystemA();
        private static SubSystemB _subSystemB = new SubSystemB();
        private static SubSystemC _subSystemC = new SubSystemC();

        public static void Operation01()
        {
            Console.WriteLine("Operation 01\n"
                + _subSystemA.A1()
                +_subSystemA.A2()
                +_subSystemB.B1());
        }

        public static void Operation02()
        {
            Console.WriteLine("Operation 02\n"
                + _subSystemB.B1()
                + _subSystemC.C1());
        }
    }
}
