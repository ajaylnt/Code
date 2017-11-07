using System;
using System.Collections.Generic;
using System.ServiceModel;
using WCFServer.DataModels;
using System.Linq;

namespace WCFServer.Components
{
    [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        List<Employee> GetAllEmployees();
        [OperationContract]
        bool AddNewEmployee(Employee emp);
        [OperationContract]
        bool DeleteEmployee(int empID);
        [OperationContract]
        bool UpdateEmployee(Employee emp);
        [OperationContract]
        List<Dept> GetAllDepartments();
    }
    public class EmpServiceComponent : IEmpService
    {
        public bool AddNewEmployee(Employee emp)
        {
            var context = new WPFDBEntity();
            var employee = new EmpTable
            {
                EmpName = emp.EmpName,
                EmpAddress = emp.EmpAddress,
                EmpSalary = emp.EmpSalary,
                Dept = emp.DeptID
            };
            context.EmpTables.Add(employee);
            context.SaveChanges();
            return true;
        }

        public bool DeleteEmployee(int empID)
        {
            var context = new WPFDBEntity();
            var emp = context.EmpTables.FirstOrDefault(e => e.EmpID == empID);
            if (emp == null)
                return false;
            context.EmpTables.Remove(emp);
            context.SaveChanges();
            return true;
        }

        public List<Dept> GetAllDepartments()
        {
            var context = new WPFDBEntity();
            var data = context.DeptTables.Select((dept) => new Dept
            {
                DeptID = dept.DeptID,
                DeptName = dept.DeptName
            });//Extracting through LAMBDA Expression....
            return data.ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            var context = new WPFDBEntity();
            var data = from emp in context.EmpTables
                       select new Employee
                       {
                           DeptID = emp.Dept == null ? 0 : emp.Dept.Value,
                           EmpID = emp.EmpID,
                           EmpName = emp.EmpName,
                           EmpAddress = emp.EmpAddress,
                           EmpSalary = emp.EmpSalary
                       }; // Dept is Nullable Type
            return data.ToList();
        }

        public bool UpdateEmployee(Employee emp)
        {
            var context = new WPFDBEntity();
            var employee = context.EmpTables.FirstOrDefault(e => e.EmpID == emp.EmpID);
            if (employee == null)
                return false;
            employee.EmpName = emp.EmpName;
            employee.EmpAddress = emp.EmpAddress;
            emp.EmpSalary = emp.EmpSalary;
            employee.Dept = emp.DeptID;
            context.SaveChanges();
            return true;
        }
    }
}