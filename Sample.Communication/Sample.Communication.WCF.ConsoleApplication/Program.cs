using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.Communication.WCF.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceConnections svc = new ServiceConnections();
            svc.ServiceNormal.GetMessageFromServiceCompleted += new EventHandler<SampleServiceWCF.GetMessageFromServiceCompletedEventArgs>(ServiceNormal_GetMessageFromServiceCompleted);
            svc.ServiceAdvance.GetStudentByScoreConditionCompleted += new EventHandler<SampleServiceWCF.GetStudentByScoreConditionCompletedEventArgs>(ServiceAdvance_GetStudentByScoreConditionCompleted);
            svc.ServiceAdvance.GetStudentCompleted += new EventHandler<SampleServiceWCF.GetStudentCompletedEventArgs>(ServiceAdvance_GetStudentCompleted);


            Console.WriteLine("Please wait for service respond...");
            svc.ServiceNormal.GetMessageFromServiceAsync();
            svc.ServiceAdvance.GetStudentAsync();
            svc.ServiceAdvance.GetStudentByScoreConditionAsync(45);
            Console.ReadLine();
        }

        static void ServiceAdvance_GetStudentByScoreConditionCompleted(object sender, SampleServiceWCF.GetStudentByScoreConditionCompletedEventArgs e)
        {
            Console.WriteLine("\n[Service get student by score condition]");
            foreach (var student in e.Result)
            {
                Console.WriteLine("Name: {0}, Score: {1}",student.Name,student.Score);
            }
        }

        static void ServiceAdvance_GetStudentCompleted(object sender, SampleServiceWCF.GetStudentCompletedEventArgs e)
        {
            Console.WriteLine("\n[Service get student]");
            var student = e.Result;
            Console.WriteLine("Name: {0}, Score: {1}", student.Name, student.Score);
        }

        static void ServiceNormal_GetMessageFromServiceCompleted(object sender, SampleServiceWCF.GetMessageFromServiceCompletedEventArgs e)
        {
            Console.WriteLine("\n[Service message]");
            Console.WriteLine(e.Result);
        }
    }
}
