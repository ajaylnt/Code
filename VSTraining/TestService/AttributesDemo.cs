/*Attributes are sp properties added to the metadata of the object at
runtime. It is set to add optional property or extra functionality
for the objects at runtime on request.Examples are serializable,
WebService, Webmethod, ServiceContract, OperationContract. These are
the attributes provided by the .NET framework for additional features
for the classes like serialization, web services support, WCF support
and many more...

Attributes are classes that are derived from System.Attribute. They
can have a TargetType which allows the attribute to be set on the type
of the component(Class, interface, struct, method, property so forth)*/

using System;
using System.Reflection;
namespace AttributeProgramming
{
    //create an attribute for our program...
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    class DebugInfo : Attribute
    {
        public DebugInfo(string developedBy, string developedOn)
        {
            this.DevelopedBy = developedBy;
            this.DevelopedOn = DateTime.Parse(developedOn);
        }
        public string DevelopedBy { get; private set; }
        public DateTime DevelopedOn { get; private set; }
    }
    /*DebugInfo is additional Information provided by the programmer for
    the application that provides the details of the debugger who has
    fixed the bug in that section of the code block...*/
    class MainClass
    {
        [DebugInfo("AjayNaidu", "06/11/2017")]
       public static void Main(string[] args)
        {
            testfunc();
            var classDetails = typeof(MainClass);
            var method = classDetails.GetMethod("Main");
            if (method != null)
            {
                var attributes = method.GetCustomAttribute<DebugInfo>();
                if (attributes != null)
                {
                    Console.WriteLine("This block of code was debugged by {0} on {1}", attributes.DevelopedBy, attributes.DevelopedOn.ToShortDateString());
                    Console.ReadKey();
                }
            }
        }

        private void displayDebugInfoForClass()
        {
            var type = typeof(MainClass);
            foreach(var attribute in type.GetCustomAttributes())
            {
                if(attribute is DebugInfo)
                {
                    var details = attribute as DebugInfo;
                    Console.WriteLine("This class was debugged by {0} on {1}",details.DevelopedBy,details.DevelopedOn.ToShortDateString());
                }
            }
        }
        [DebugInfo("Anil Naidu", "13/12/2017")]
        public static void testfunc()
        {
            Console.WriteLine("Test Function is Invocked here...");
            Console.ReadKey();

        }

    }
}