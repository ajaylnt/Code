using System.Runtime.Serialization;

[DataContract]
public class Employee
{
    [DataMember]
    public int EmpID { get; set; }
    [DataMember]
    public string EmpName { get; set; }
    [DataMember]
    public string EmpAddress { get; set; }
    [DataMember]
    public int EmpSalary { get; set; }
    [DataMember]
    public int DeptID { get; set; }

    //When U want to modify the base class function in ur Derived class,
    //then U could override them.
    public override string ToString()
    {
        return base.ToString();
    }
}
[DataContract]
public class Dept
{
    [DataMember]
    public int DeptID { get; set; }
    [DataMember]
    public string DeptName { get; set; }
}