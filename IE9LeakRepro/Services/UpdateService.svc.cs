using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using IE9LeakRepro.Model;

namespace IE9LeakRepro.Services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UpdateService
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        [WebInvoke(RequestFormat=WebMessageFormat.Json, ResponseFormat=WebMessageFormat.Json, BodyStyle=WebMessageBodyStyle.WrappedRequest)]
        public UpdateResponse<GraphicItem> GetGraphicUpdates()
        {
            var listOfUpdates = GetUpdates();
            return new UpdateResponse<GraphicItem>(listOfUpdates, string.Empty);
        }

        private IList<GraphicItem> GetUpdates()
        {
            List<GraphicItem> items = new List<GraphicItem>();
            for(int i=0;i<300;i++)
            {
                items.Add(new GraphicItem()
                              {
                                  bgColor = System.Drawing.Color.AliceBlue,
                                  AddTemporaryOverrideArgs = "test",
                                  CategoryId = i,
                                  ChangeValueArgs = "none",
                                  ClassId = i,
                                  errorCode = 0x234,
                                  ErrorText = "None",
                                  fgColor = System.Drawing.Color.Aquamarine,
                                  fqr = "fsfsd",
                                  isChangeable = false,
                                  isInAlarm = true,
                                  isNormalStatus = false,
                                  isOverrideable = true,
                                  isViewable = false,
                                  Name = "My Name",
                                  NavigateUrl = "http://www.bing.com",
                                  NodeType = 9,
                                  Status = "Testing", 
                                  StatusId = 2
                              });
            }
            return items;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
