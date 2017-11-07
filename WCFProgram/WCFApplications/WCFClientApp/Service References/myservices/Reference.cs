﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClientApp.myservices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="myservices.IEmpService")]
    public interface IEmpService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/GetAllEmployees", ReplyAction="http://tempuri.org/IEmpService/GetAllEmployeesResponse")]
        System.Collections.Generic.List<Employee> GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/GetAllEmployees", ReplyAction="http://tempuri.org/IEmpService/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Employee>> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/AddNewEmployee", ReplyAction="http://tempuri.org/IEmpService/AddNewEmployeeResponse")]
        bool AddNewEmployee(Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/AddNewEmployee", ReplyAction="http://tempuri.org/IEmpService/AddNewEmployeeResponse")]
        System.Threading.Tasks.Task<bool> AddNewEmployeeAsync(Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/DeleteEmployee", ReplyAction="http://tempuri.org/IEmpService/DeleteEmployeeResponse")]
        bool DeleteEmployee(int empID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/DeleteEmployee", ReplyAction="http://tempuri.org/IEmpService/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int empID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmpService/UpdateEmployeeResponse")]
        bool UpdateEmployee(Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmpService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/GetAllDepartments", ReplyAction="http://tempuri.org/IEmpService/GetAllDepartmentsResponse")]
        System.Collections.Generic.List<Dept> GetAllDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/GetAllDepartments", ReplyAction="http://tempuri.org/IEmpService/GetAllDepartmentsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Dept>> GetAllDepartmentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpServiceChannel : WCFClientApp.myservices.IEmpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpServiceClient : System.ServiceModel.ClientBase<WCFClientApp.myservices.IEmpService>, WCFClientApp.myservices.IEmpService {
        
        public EmpServiceClient() {
        }
        
        public EmpServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Employee> GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Employee>> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public bool AddNewEmployee(Employee emp) {
            return base.Channel.AddNewEmployee(emp);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewEmployeeAsync(Employee emp) {
            return base.Channel.AddNewEmployeeAsync(emp);
        }
        
        public bool DeleteEmployee(int empID) {
            return base.Channel.DeleteEmployee(empID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int empID) {
            return base.Channel.DeleteEmployeeAsync(empID);
        }
        
        public bool UpdateEmployee(Employee emp) {
            return base.Channel.UpdateEmployee(emp);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(Employee emp) {
            return base.Channel.UpdateEmployeeAsync(emp);
        }
        
        public System.Collections.Generic.List<Dept> GetAllDepartments() {
            return base.Channel.GetAllDepartments();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Dept>> GetAllDepartmentsAsync() {
            return base.Channel.GetAllDepartmentsAsync();
        }
    }
}