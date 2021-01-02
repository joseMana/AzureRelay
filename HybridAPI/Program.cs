using Microsoft.ServiceBus;
using System;
using System.Configuration;
using System.ServiceModel.Web;

namespace JosephM.Relay
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = ServiceBusEnvironment.CreateServiceUri("https", ConfigurationManager.AppSettings["RelayServiceNamespace"], "Hybrid");
            string tokenForClient = SharedAccessSignatureTokenProvider.GetSharedAccessSignature(
                ConfigurationManager.AppSettings["ClientKeyName"], 
                ConfigurationManager.AppSettings["ClientKey"], 
                address.ToString(), 
                new TimeSpan(0, 1, 1, 1));

            WebServiceHost host = new WebServiceHost(typeof(HybridService), address);
            host.Open(); 

            Console.ReadLine();

            host.Close();
        }
    }
}
