using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Employee
    {
        public int EmpID { get; set; }
        public string Empname { get; set; }
        public string Empaddress { get; set; }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            firstDemo();
            secondDemo();
        }
        private static List<Employee>createEmpList()
        {
            return new List<Employee>
            {
                new Employee { EmpID=101,Empname="Ajay Kumar",Empaddress="Mysore"},
                new Employee { EmpID=102,Empname="Sai Kumar",Empaddress="Mysore"},
                new Employee { EmpID=103,Empname="Shravan Kumar",Empaddress="Mysore"},
                new Employee { EmpID=104,Empname="Ashok Kumar",Empaddress="Bangalore"},
                new Employee { EmpID=105,Empname="Anil Kumar",Empaddress="Mysore"},
                new Employee { EmpID=106,Empname="Durga",Empaddress="Bangalore"},
                new Employee { EmpID=107,Empname="Siva Kumar",Empaddress="Mysore"},
                new Employee { EmpID=108,Empname="Murali",Empaddress="Mysore"},
                new Employee { EmpID=109,Empname="Shoban Kumar",Empaddress="Bangalore"},
                new Employee { EmpID=110,Empname="Divya",Empaddress="Mysore"},
            };
        }
        private static void secondDemo()
        {
            List<Employee> employees = createEmpList();
            Console.WriteLine("Find the Employees by city");
            string city = Console.ReadLine();

            var tempList = employees.FindAll((emp) => emp.Empaddress.ToUpper() == city.ToUpper());
            foreach (var emp in tempList)
                Console.WriteLine("{0} from {1}",emp.Empname,emp.Empaddress);
        }
        private static void firstDemo()
        {
            int[] scores = { 67, 76, 56, 87, 58, 96, 58, 67, 86, 78 };
            //These functions were added to support LINQ operations on collections...
            Console.WriteLine("The max score is" + scores.Max());
            Console.WriteLine("The min score is" + scores.Min());
            Console.WriteLine("The avg score is" + scores.Average());
            //Get the scores greater than average....
            var greaterScores = scores.Where(s => s > scores.Average());
            foreach (var score in greaterScores)
                Console.WriteLine(score);
            Console.WriteLine("Enter the score to find");
            int findingscore = int.Parse(Console.ReadLine());
            var selectedScores = scores.Where(s => s == findingscore);
            /*All Extension methods of LINQ will return a collection, whose values
            are extracted using foreach statement....*/
            foreach (var item in selectedScores)
                Console.WriteLine(item);
        }
    }
}