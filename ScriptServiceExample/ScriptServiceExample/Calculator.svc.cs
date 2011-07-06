using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web.Script.Services;

namespace ScriptServiceExample
{
    [ServiceContract(Namespace = "Samples.Services")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Calculator
    {
        // Add [WebGet] attribute to use HTTP GET
        [OperationContract]
        public int Add(int num1, int num2)
        {
            // Add your operation implementation here
            return num1 + num2;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
