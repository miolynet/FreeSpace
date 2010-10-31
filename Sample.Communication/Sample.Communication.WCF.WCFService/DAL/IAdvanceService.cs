using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Sample.Communication.WCF.WCFService.DAL
{
    [ServiceContract]
    public interface IAdvanceService
    {
        [OperationContract]
        Student GetStudent();

        [OperationContract]
        IEnumerable<Student> GetStudentByScoreCondition(int minScore);
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Score { get; set; }
    }
}