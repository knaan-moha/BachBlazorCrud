using BachCrud.Server.Data;
using BachCrud.Server.Models;
using BlazorCrud.Server.Models;

using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace BlazorCrud.Server.Respositories;

public class StudentRepository : IStudentRepository
{


    private readonly ApplictionDbContext _dbContext;

    public StudentRepository(ApplictionDbContext dbContext)
    {
        _dbContext = dbContext; 
    }
    
    
    
    
    
    public async Task<IEnumerable<Student>> GetStudents()
    {
        var students = await _dbContext.Students.Include(d=>d.Courses).ToListAsync();

        return students; 
    }
    
    public async Task<Student> AddStudent(Student student)
    {
        _dbContext.Students.Add(student);
        await _dbContext.SaveChangesAsync();
        return student; 

    }

    public async Task<Student> UpdateStudent(Student student)
    {
      
        _dbContext.Students.Update(student);
        await _dbContext.SaveChangesAsync();
        return student; 
    }

    public async Task<Student> Delete(int id)
    {
        var result = await _dbContext.Students.FirstOrDefaultAsync(e => e.Id == id);
        return result!; 
    }

    public async Task<Student> GetStudentById(int id)
    {
        var result = await _dbContext.Students.FirstOrDefaultAsync(e => e.Id == id);
        return result!; 
    }

    public async Task SaveChangesAsync()
    {
       await _dbContext.SaveChangesAsync(); 
    }

    public async Task DeleteStudents(Student student)
    {
        _dbContext.Students.Remove(student);
        await _dbContext.SaveChangesAsync(); 

    }
}