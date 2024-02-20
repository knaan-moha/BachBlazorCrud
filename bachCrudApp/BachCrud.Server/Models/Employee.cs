namespace BlazorCrud.Server.Models;

public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }

    public int Salary { get; set; }
    public DateTime HireData { get; set; }
    public int DepartmentId { get; set; }

    public virtual Department Department { get; set;  } 
}