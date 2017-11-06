using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;

//Make sure that the namespace, project name and the class names are same in UR program
namespace RemoteObjectLib
{
    //If the class instance has to be acceessed remotely, then the class should be derived from
    //MarshalByRefObject class.. Then the object of this class could be accessed remotely through a 
    //PROXY object created by the client...
    public class Messenger : MarshalByRefObject
    {
        public void PostMessage(string message)
        {
            string user = Environment.UserName; //Gives the current user logged to the windows OS
            Console.WriteLine("{0}:{1}", user, message);
        }
    } 
}
