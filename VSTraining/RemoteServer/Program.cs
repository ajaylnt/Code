using RemoteObjectLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemoteServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(1234);
            ChannelServices.RegisterChannel(channel, true);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Messenger),
                "MessengerService", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server is ready to handle the requests\nPress any key to exit the service");
            Console.ReadKey();
        }
    }
}
