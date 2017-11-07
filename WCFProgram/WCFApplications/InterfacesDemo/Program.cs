using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    interface iSample
    {
        void SampleFunc();
    }
    interface iExample
    {
        void ExampleFunc();
    }
    class Sample : iSample, iExample
    {
        void iExample.ExampleFunc()
        {
            throw new NotImplementedException();
        }

        void iSample.SampleFunc()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
