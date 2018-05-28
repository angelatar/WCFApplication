using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookNS;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCFApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:4505/BookNS/Library");

            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(BookNS.Library),httpUrl);

            //Add a service endpoint
            host.AddServiceEndpoint(typeof(BookNS.ILibrary), new BasicHttpBinding(), "");

            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            //smb.HttpsGetUrl = httpUrl;
            host.Description.Behaviors.Add(smb);

            //Start the Service
            host.Open();
            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press  key to stop");
            Console.ReadLine();
        }
    }
}
