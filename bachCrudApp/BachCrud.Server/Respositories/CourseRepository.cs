using BachCrud.Server.Data;
using BlazorCrud.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.Respositories;

public class CourseRepository : ICourseRepository
{
    private readonly ApplictionDbContext _dbContext;

    public CourseRepository(ApplictionDbContext dbContext)
    {
        _dbContext = dbContext; 
    }
    
    
    
    public async Task<IEnumerable<Course>> GetCourses()
    {

        var courses = await _dbContext.Courses.ToListAsync();

        return courses; 
    }
}