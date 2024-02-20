using BachCrud.Server.Models;

namespace BlazorCrud.Server.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }


    public virtual ICollection<Student> Students { get; } = new List<Student>(); 
}