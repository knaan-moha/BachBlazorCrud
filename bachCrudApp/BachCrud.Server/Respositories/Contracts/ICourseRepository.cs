using BlazorCrud.Server.Models;

namespace BlazorCrud.Server.Respositories;

public interface ICourseRepository
{

    Task<IEnumerable<Course>> GetCourses(); 


}