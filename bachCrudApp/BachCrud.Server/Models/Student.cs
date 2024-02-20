using BlazorCrud.Server.Models;

namespace BachCrud.Server.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int  Age { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }

    public int  CourseId { get; set; }
    
    public virtual Course  Courses  { get; set; }
}