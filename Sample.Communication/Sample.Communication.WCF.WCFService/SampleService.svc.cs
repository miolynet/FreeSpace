using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sample.Communication.WCF.WCFService.DAL;

namespace Sample.Communication.WCF.WCFService
{
    public class SampleService : INormalService,IAdvanceService
    {
        #region ISampleService members

        public string GetMessageFromService()
        {
            return "Hello world from service.";
        }

        #endregion ISampleService members

        #region IAdvanceService members

        public Student GetStudent()
        {
            return new Student
            {
                Name = "Hello world from advance service",
                Score = 99
            };
        }

        public IEnumerable<Student> GetStudentByScoreCondition(int minScore)
        {
            List<Student> studentList = new List<Student>
            {
               new Student{Name = "A", Score = 0},
               new Student{Name = "B", Score = 20},
               new Student{Name = "C", Score = 40},
               new Student{Name = "D", Score = 60},
               new Student{Name = "E", Score = 80},
               new Student{Name = "A", Score = 100},
            };

            return studentList.Where(s => s.Score >= minScore);
        }

        #endregion IAdvanceService members
    }
}
