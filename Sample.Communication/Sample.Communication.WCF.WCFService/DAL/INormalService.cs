using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace Sample.Communication.WCF.WCFService.DAL
{
    [ServiceContract]
    public interface INormalService
    {
        [OperationContract]
        string GetMessageFromService();
    }
}