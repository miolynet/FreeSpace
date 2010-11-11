using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client s1 = new ServiceReference1.Service1Client();

            s1.GetNumberCompleted += new EventHandler<ServiceReference1.GetNumberCompletedEventArgs>(s1_GetNumberCompleted);
            
            s1.GetNumberAsync();
            s1.GetNumberAsync();
            s1.GetNumberAsync();
            s1.GetNumberAsync();

            Console.ReadLine();
        }

        static void s1_GetNumberCompleted(object sender, ServiceReference1.GetNumberCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
