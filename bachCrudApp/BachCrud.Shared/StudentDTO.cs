using BlazorCrud.Shared;

namespace BachCrud.Shared;

public class StudentDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; set; }

    public int  CourseId { get; set; }

    public CourseDTO? CourseDto { get; set; }
}