using BachCrud.Server.Models;
using BlazorCrud.Server.Models;

namespace BlazorCrud.Server.Respositories;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetStudents();

   
    Task<Student> AddStudent(Student student);
    Task<Student> UpdateStudent(Student student);
    Task<Student> Delete(int id);
    Task<Student> GetStudentById(int id);

    Task SaveChangesAsync();

    Task DeleteStudents(Student student); 



}