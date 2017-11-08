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
    delegate double MathOperation(double op1, double op2);
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
            //InvokeMethod method = new InvokeMethod(TestFunc);
            //CallBackFunc(method);

            //Latest Type of Syntax
            //CallBackFunc(TestFunc);

            /*Anonymous methods in C#. Here U have created a method with no naem, So
            its called as Anonymous methods...*/
            InvokeMethod delegateObj = delegate ()
            {
                Console.WriteLine("Anonymous func is called by the callback function");
            };
            //CallBackFunc(delegateObj);//invoking through anonymous method...

            CallBackFunc(() =>
            {
                Console.WriteLine("Lambda Expression is invoked by callback func");
                Console.WriteLine("One more line of execution");
                Console.WriteLine("Finishing the function job");
            });

            //Delegate instances are also called alias to methods that it is invoking.
            //MathOperation addFunc = delegate (double v1, double v2)
            //{
            //    return v1 + v2;
            //};
            //var res = addFunc(123, 152);
            //Console.WriteLine(res);
            //res = addFunc(235, 452);
            //Console.WriteLine(res);
            //Console.WriteLine("The Added value is" + addFunc(123, 152));

            InvokeMethod op = () => Console.WriteLine("Testing 123,152");
            op();
            MathOperation anyFunc = (v1, v2) => (2 * v1 * 4 * v2) / v1 + v2 * v1 - v1;
            var res = anyFunc(152, 152);
            Console.WriteLine(res);
        }
        static void TestFunc()
        {
            Console.WriteLine("Test Func is called by the callback function");
            Console.ReadKey();
        }
    }
}
