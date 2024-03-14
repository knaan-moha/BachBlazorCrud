using BachCrud.Server.Data;
using BlazorCrud.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.Respositories;

public class CourseRepository : ICourseRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CourseRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext; 
    }
    
    
    
    public async Task<IEnumerable<Course>> GetCourses()
    {

        var courses = await _dbContext.Courses.ToListAsync();

        return courses; 
    }
}