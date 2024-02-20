using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Server.Respositories;
using BlazorCrud.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository; 
        }




        [HttpGet]
        [Route("AllCourses")]
        public async Task<IActionResult> AllCourses()
        {

            var responseAPi = new ResponseAPI<System.Collections.Generic.List<CourseDTO>>();
           



            try
            {
                // using link Quary 
                var courses = await _courseRepository.GetCourses();
                
                var courseDTOlist = courses.Select(item => new CourseDTO
                {
                    Id = item.Id, 
                    Name = item.Name


                }).ToList(); 

               
                responseAPi.IsSuccess = true;
                responseAPi.Value = courseDTOlist;


            }
            catch (Exception e)
            {
                
                responseAPi.IsSuccess =false;
                responseAPi.Message = e.Message; 
            }
            
            return responseAPi.IsSuccess ? Ok(responseAPi) : BadRequest(responseAPi);
        }

            
        }


    }

