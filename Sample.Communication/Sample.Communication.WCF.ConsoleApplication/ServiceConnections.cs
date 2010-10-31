using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.Communication.WCF.ConsoleApplication.SampleServiceWCF;

namespace Sample.Communication.WCF.ConsoleApplication
{
    /// <summary>
    /// Service connection class
    /// </summary>
    public class ServiceConnections
    {
        /// <summary>
        /// Normal service
        /// </summary>
        public NormalServiceClient ServiceNormal { get; set; }

        /// <summary>
        /// Advance service
        /// </summary>
        public AdvanceServiceClient ServiceAdvance { get; set; }

        /// <summary>
        /// Initialize service
        /// </summary>
        public ServiceConnections()
        {
            ServiceNormal = new NormalServiceClient();
            ServiceAdvance = new AdvanceServiceClient();
        }
    }
}
