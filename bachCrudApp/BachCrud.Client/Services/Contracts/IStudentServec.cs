using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCrud.Shared;

namespace BlazorCrud.Client.Services;

public interface IStudentServec
{
    Task<List<StudentDTO>> AllStudents();

    Task<StudentDTO> Search(int id);

    Task<int> Save(StudentDTO studentDto);

    Task<int> Edit(StudentDTO studentDto); 

    Task<bool> Delete(int id);
}