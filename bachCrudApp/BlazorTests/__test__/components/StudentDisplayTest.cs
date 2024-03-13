using BachCrud.Client.Pages;
using BlazorCrud.Client.Services;
using BlazorCrud.Shared;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlazorTests.__test__.components;

public class StudentDisplayTest : TestContext 
{

    [Fact]
    public async Task ShouldDisplayStudentList()
    {
        // mocking the services 

        var mockStudentService = new Mock<IStudentService>();
        var mockStudnets = new List<StudentDTO>
        {
            new StudentDTO
            {
                Id = 1, FirstName = "knaan", LastName = "mohamed", Age = 23, PhoneNumber = "4848484",
                CourseDto = new CourseDTO { Name = "IKT-206" }, RegistrationDate = new DateTime(2024, 3, 6)
            },

        };
        mockStudentService.Setup(s => s.AllStudents()).ReturnsAsync(mockStudnets);
        Services.AddSingleton<IStudentService>(mockStudentService.Object);

        var component = RenderComponent<Students>();

        foreach (var student in mockStudnets)
        {
            Assert.Contains(student.FirstName, component.Markup);
            Assert.Contains(student.LastName, component.Markup);
            
            var studentsAge = student.Age.ToString();
            Assert.Contains(studentsAge, component.Markup);

            Assert.Contains(student.CourseDto!.Name, component.Markup);

            var formatRegisterDate = student.RegistrationDate.ToString("dd.MM.yyyy");
            Assert.Contains(formatRegisterDate, component.Markup); 
            
        }

    }
}