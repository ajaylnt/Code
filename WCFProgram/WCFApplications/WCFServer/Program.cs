using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

//WCF needs 2 Assemblies: "System.ServiceModel,System.Runtime.Serialization"

/*
--> ServiceModel namespace contain the Attributes required for WCF as well as
    Classes requiured for hosting and configuring the WCF Components.
--> Self Hosting means an exclusive .NETAPP would be created whose job is to
    creeate the objects of the WCF Components in it and these objects will be
    consumed by the Client Applications using RPC
-->There are 3 ways to create WCF Apps:
   1)WAS(Windows Activation Service)
   2)Self Hosting
   3)IIS(the most preferable way)
-->In self hosting, we have regular .NET Apps to host and Windows Services
  (Services that run on the Windows OS using SCM(Service Control Manager))
*/
using WCFServer.Components;
namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostApp = new ServiceHost(typeof(EmpServiceComponent));
            //Exception Handling
            try
            {
                hostApp.Open();
                Console.WriteLine("The host is ready to receive the requests");
                Console.WriteLine("Press any key to close the App...");
                Console.ReadKey();
                hostApp.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }
            finally
            {
                Console.WriteLine("The Application has Terminated....");
            }
        }
    }
}
