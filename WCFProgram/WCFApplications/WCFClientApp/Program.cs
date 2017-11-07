using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClientApp.MyServiceref;
//Add the service reference by providing the URL of the service:
//net.tcp://localhost:1234/myservices/

namespace WCFClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpServiceClient client = new EmpServiceClient();
            var data = client.GetAllEmployees();
            foreach (var item in data)
                Console.WriteLine(item.EmpName);
        }
    }
}
