using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteObjectLib;

namespace RemoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClientChannel channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(channel, true);
            var proxy = Activator.GetObject(typeof(Messenger), "tcp://localhost/MessengerService") as Messenger;
            bool process = true;
            while (process)
            {
                Console.WriteLine("Enter the Message to post");
                proxy.PostMessage(Console.ReadLine());
                Console.WriteLine("Press Y to send new message");
                process = Console.ReadLine() == "Y";
            }
            Console.WriteLine("The Application is terminating....");
        }
    }
}
