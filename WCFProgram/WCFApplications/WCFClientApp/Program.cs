using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClientApp.myservices;

//Add the service reference by providing the URL of the service:
//net.tcp://localhost:1234/myservices/

namespace WCFClientApp
{
    class Program
    {
        static IEmpService component = new EmpServiceClient();
        static void Main(string[] args)
        {
            var filename = args[0];//Path of the file to read...
            StreamReader reader = new StreamReader(filename);//Used to read .txt based files
            bool processing = true;
            string menu = reader.ReadToEnd();
            do
            {
                Console.Clear();
                string choice = GetString(menu);
                processing = processMenu(choice);
                Console.WriteLine("Press Any Key to Display Menu");
                Console.ReadKey();
            } while (processing);
        }
        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                default:
                    return false;
                case "1":
                    readAllEmployees();
                    return true;
                case "2":
                case "3":
                case "4":
                case "5":
                    return true;
            }
        }
        private static void addingEmployee()
        {
            var emp = new Employee();
            emp.EmpName = UIHelper.GetString("Enter the Name");
            emp.EmpAddress = UIHelper.GetString("Enter the Address");
            emp.EmpSalary = UIHelper.GetInteger("Enter the Salary");
            emp.DeptID = UIHelper.GetInteger("Enter the DeptID");
            if (component.AddNewEmployee(emp))
            {
                Console.WriteLine("Employee not added");
            }
            else
            {
                Console.WriteLine("Employee not added");
            }
        }
        private static void findEmployee()
        {
            var employees = component.GetAllEmployees();
            foreach (var emp in employees)
                Console.WriteLine(emp.EmpName);
            Console.WriteLine("Please enter the Name or part of the Name to find the details");
            string name = Console.ReadLine();
            var tempList = employees.FindAll(e =>
            e.EmpName.Contains(name));
            foreach (var emp in tempList)
                Console.WriteLine(string.Format("Name:{0}\tAddress:{1}\tSalary:{2}", emp.EmpName, emp.EmpAddress, emp.EmpSalary));
        }
        public static void readAllEmployees()
        {
            var employees = component.GetAllEmployees();
            foreach (var emp in employees)
                Console.WriteLine(string.Format("Name:{0}\tAddress:{1}\tSalary:{2}", emp.EmpName, emp.EmpAddress, emp.EmpSalary));
        }
        static class UIHelper
        {
            public static int GetInteger(string question)
            {
                Console.WriteLine(question);
                return int.Parse(Console.ReadLine());

            }
            public static string GetString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }
        }

        //EmpServiceClient client = new EmpServiceClient();
        //var data = client.GetAllEmployees();
        //foreach (var item in data)
        //    Console.WriteLine(item.EmpName);
    }
}

/*
Create a break point in the Client Application and allow the App to hit the break point.
Open the processes window of Debug windows.
Right click on the Executing process id to attach the server process.
Identify the server process and attach it to the Client App.
Press F11 to get into the Server function and then continue with F10 or any appropriate Function key...
After hitting, exit the application instance
*/
