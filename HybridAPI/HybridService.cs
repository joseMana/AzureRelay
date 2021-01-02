using System.ServiceModel;
using System.ServiceModel.Web;

namespace JosephM.Relay
{
    [ServiceBehavior(Name = "HybridService", Namespace = "http://josepmrelay.azurewebsites.com/ServiceModel/Relay/")]
    class HybridService : IHybridContract
    {
        public HybridService()
        {
        }
        public string GetJSON(ComplexType complextType)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";

            return "qwerty";
        }
    }
}