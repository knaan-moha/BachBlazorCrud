using BachCrud.Client.Pages;
using BachCrud.Shared;
using BlazorCrud.Client.Services;
using BlazorCrud.Shared;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlazorTests.__test__.components;

public class StudentComponentTests : TestContext
{
    [Fact]

    public async Task ShouldDeleteStudent()
    {
        
        
        // mocking the student 

        var mockStudent = new Mock<IStudentService>(); 
        
        // make fake existing student list 

        var deleteExistingStudent = new List<StudentDTO>
        {
            new StudentDTO
            {
                Id = 1, FirstName = "Zekaria", LastName = "mohamed", Age = 26,
                CourseDto = new CourseDTO { Name = "IKT206" }, RegistrationDate = DateTime.Now
            }, 
            new StudentDTO
            {
                Id = 2, FirstName = "Kate", LastName = "test", Age = 26,
                CourseDto = new CourseDTO { Name = "IKT206" }, RegistrationDate = DateTime.Now
            }
        }; 
        
        
        // setting up mocking student services 

        mockStudent.Setup(s => s.AllStudents()).ReturnsAsync(deleteExistingStudent);
        mockStudent.Setup(s => s.Delete(1)).ReturnsAsync(true).Callback(() => deleteExistingStudent.RemoveAt(0)); 
        
        // Registering for the student service 

        Services.AddSingleton<IStudentService>(mockStudent.Object);

        var component = RenderComponent<Students>();
        
        // making invoke for the DeleteStudent method 
        await component.InvokeAsync(() => component.Instance.DeleteStudent(1)); 
        
        mockStudent.Verify(s=>s.Delete(1), Times.Once);
        
        //optionally re-render the component 
        component.Render();
        
        // check if  does not contains removed student firstName
        Assert.DoesNotContain("Zekaria", component.Markup);
        
        Assert.Contains("Kate", component.Markup); 

    }
    
    
}