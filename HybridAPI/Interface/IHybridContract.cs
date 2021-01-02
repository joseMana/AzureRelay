using System.ServiceModel;
using System.ServiceModel.Web;

namespace JosephM.Relay
{
    [ServiceContract(Name = "HybridContract", Namespace = "http://josepmrelay.azurewebsites.com/ServiceModel/Relay/")]
    [XmlSerializerFormat]
    public interface IHybridContract
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "testpostoperation/", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        string GetJSON(ComplexType complextType);
    }
}