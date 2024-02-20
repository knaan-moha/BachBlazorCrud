using BlazorCrud.Shared;

namespace BachCrud.Client.Services.Contracts;

public interface ICourseService
{
    Task<List<CourseDTO>> List(); 
    
}