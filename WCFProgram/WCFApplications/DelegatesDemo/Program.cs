using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    /*
    --->A function which calls another function that is passed as argument to it,
        the function that is passed as argument is called as callback function.
        This function will be usually called after the current function finishes its
        operation and then invokes the function as an acknowledgement.
    --->U need a reference of a function to be passed as argument.
        This is called as Delegate.
    */
    delegate void InvokeMethod();
    class MainClass
    {
        static void CallBackFunc(InvokeMethod method)
        {
            Console.WriteLine("Doing some job in the callback function");
            method();//Invoke the reference object that is passed as argument...
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            InvokeMethod method = new InvokeMethod(TestFunc);
            CallBackFunc(method);

            CallBackFunc(TestFunc);
        }
        static void TestFunc()
        {
            Console.WriteLine("Test Func is called by the callback function");
            Console.ReadKey();
        }
    }
}
