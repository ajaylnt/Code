/*WCF stands for Windows Communication Foundation, the next generation
Service oriented Application Framework for developing services across
different platforms & different protocols. U could use the same
framework for developing all sorts of service oriented components like
REST, Web based services, Windows services and many more....

It supports various protocols like WSHTTP, HTTP, HTTPS, TCP, SOAP and many more.
All the protocols are configurable through XML config file.
There will be a loose coupling of the service components and its exposed operrations.

System.ServiceModel and System.Runtime.Serialization are the important assemblies
that are referenced when u create a WCF Service

WCF supports functions to be exposed as interfaces. U always create an interface
that contain the methods that U wish to expose

WCF also uses WSDL for exposing its services to outside non .NET Clients
So here also, we use attributes for exposing the components.

Interfaces are provided with attribute called ServiceContract. This
means that the service exposed the methods of this interface...
The methods that are exposed are called OperationContracts.*/

using System;
using System.ServiceModel;

namespace WcfProgramming
{
    [ServiceContract]
    public interface IMathComponent
    {
        double AddFunc(double v1, double v2);
        double SubFunc(double v1, double v2);
    }
    /*This is the class that implements the service contract. This class will be
    hidden to the clients. Clients are exposed only to the ServiceContract, not the implementor class...*/
    public class MathComponent : IMathComponent
    {
        public double AddFunc(double v1, double v2)
        {
            return v1 + v2;
        }

        public double SubFunc(double v1, double v2)
        {
            return v1 - v2;
        }
    }
}