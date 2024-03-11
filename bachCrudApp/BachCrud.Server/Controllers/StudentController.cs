using BachCrud.Server.Models;
using BlazorCrud.Server.Respositories;
using BlazorCrud.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BachCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository; 
            
        }
        
        [HttpGet]
        [Route("AllStudents")]
        public async Task<IActionResult> AllStudents()
        {
            var responseApi = new ResponseAPI<List<StudentDTO>>();
            try
            {
                var students = await _studentRepository.GetStudents();
                // make linkQ to iteret over and convert to list 
                var studenDTOList = students.Select(item => new StudentDTO
                {
                    
                    Id = item.Id, 
                    FirstName = item.FirstName, 
                    LastName = item.LastName, 
                    Email = item.Email, 
                    Age = item.Age,
                    PhoneNumber = item.PhoneNumber ,
                    RegistrationDate = item.RegistrationDate, 
                    CourseDto = new CourseDTO
                    {
                        Id = item.CourseId,
                        Name = item.Courses.Name, 
                        
                        
                    }
                }).ToList();

                responseApi.IsSuccess = true;
                responseApi.Value = studenDTOList; 
            }
            catch (Exception e)
            {
                responseApi.IsSuccess = false;
                responseApi.Message = e.Message; 
            }

            return responseApi.IsSuccess ? Ok(responseApi) : BadRequest(responseApi);
            
        }
        
        
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save(StudentDTO studentDto)
        {

            var responsAPi = new ResponseAPI<int>();

            try
            {
                var studentDb = new Student
                {
                    FirstName = studentDto.FirstName, 
                    LastName = studentDto.LastName, 
                    Email = studentDto.Email, 
                    PhoneNumber = studentDto.PhoneNumber, 
                    Age = studentDto.Age, 
                    RegistrationDate = studentDto.RegistrationDate, 
                    CourseId = studentDto.CourseId,
                    
                    
                };
                await _studentRepository.AddStudent(studentDb); 
                _studentRepository.SaveChangesAsync();
                
                
                // check if the id 
                if (studentDb.Id != 0)
                {
                    responsAPi.IsSuccess = true;
                    responsAPi.Value = studentDb.Id;
                }
                else
                {
                    responsAPi.IsSuccess = false;
                    responsAPi.Message = "Not saved Students! "; 
                }

            }
            catch (Exception e)
            {
                responsAPi.IsSuccess = false;
                responsAPi.Message = e.Message; 
                
            }
            return responsAPi.IsSuccess ? Ok(responsAPi) : BadRequest(responsAPi);


        }
        [HttpGet]
        [Route("Search/{id:int}")]
        public async Task<IActionResult> Search(int id)
        {
            var responseApi = new ResponseAPI<StudentDTO>();
            var studenDto = new StudentDTO();
            
            
            try
            {
                //get records from the db using by id 
                var studentDb = await _studentRepository.GetStudentById(id); 
                
                // check if the id is not null to get the right records

                if (studentDb.Id!= null)
                {
                    studenDto.Id = studentDb.Id;
                    studenDto.FirstName = studentDb.FirstName;
                    studenDto.LastName = studentDb.LastName;
                    studenDto.Email = studentDb.Email;
                    studenDto.Age = studentDb.Age;
                    studenDto.PhoneNumber = studentDb.PhoneNumber;
                    studenDto.RegistrationDate = studentDb.RegistrationDate;
                    studenDto.CourseId = studentDb.CourseId;


                    responseApi.IsSuccess = true;
                    responseApi.Value = studenDto; 
                }
                else
                {
                    responseApi.IsSuccess = false;
                    responseApi.Message = "Not found Users reacord!";
                }

            }
            catch (Exception e)
            {
                responseApi.IsSuccess = false;
                responseApi.Message = e.Message;
                
            }

            return responseApi.IsSuccess ? Ok(responseApi) : BadRequest(responseApi);

        }
        
        [HttpPut]
        [Route("Edit/{id:int}")]
        public async Task<IActionResult> Edit(StudentDTO studentDto, int id)
        {
            var responseApi = new ResponseAPI<int>(); 
            

            try
            {
                // retrieve student from the db
                var studentDb =await _studentRepository.GetStudentById(id); 
                
                // check if the student exist in the db 

                if (studentDb.Id != null)
                {

                    studentDb.FirstName = studentDto.FirstName;
                    studentDb.LastName = studentDto.LastName;
                    studentDb.Email = studentDto.Email;
                    studentDb.Age = studentDto.Age;
                    studentDb.RegistrationDate = studentDto.RegistrationDate;
                    studentDb.CourseId = studentDto.CourseId;
                    studentDb.PhoneNumber = studentDto.PhoneNumber;
                    
                    await _studentRepository.UpdateStudent(studentDb); 
                    _studentRepository.SaveChangesAsync();
                    


                    responseApi.IsSuccess = true;
                    responseApi.Value = studentDb.Id; 
                }
                else
                {
                    responseApi.IsSuccess = false;
                    responseApi.Message = "Records not found!"; 
                    
                }

            }
            catch (Exception e)
            {
                responseApi.IsSuccess = false;
                responseApi.Message = e.Message; 
                

            }
            
            return responseApi.IsSuccess? Ok(responseApi) : BadRequest(responseApi); 
        }
        
        
        [HttpDelete]
        [Route("Delete/{id:int}")]
        public async Task<IActionResult> Delete(
            
            int id)
        {

            var reponseApi = new ResponseAPI<int>();

            try
            {
                var studentDb = await _studentRepository.GetStudentById(id);
                if (studentDb.Id != null)
                {
                  await  _studentRepository.DeleteStudents(studentDb);
                  await _studentRepository.SaveChangesAsync();

                  reponseApi.IsSuccess = true;

                }
                else
                {
                    reponseApi.IsSuccess = false;
                    reponseApi.Message = "Student record not found!";
                }
            }
            catch (Exception e)
            {
                reponseApi.IsSuccess = false;
                reponseApi.Message = e.Message; 

            }
            
            
            return reponseApi.IsSuccess? Ok(reponseApi) : BadRequest(reponseApi); 

        }
        
        
        
        

    }
}
