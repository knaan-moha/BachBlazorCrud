using BachCrud.Client.Pages;
using BachCrud.Client.Services.Contracts;
using Bunit;
using Moq;
using BlazorCrud.Client.Services;
// Assuming the correct namespace
using BlazorCrud.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BlazorTests;

public class StudentComponentTests : TestContext
{
    
    public StudentComponentTests()
    {
        var mockStudentService = new Mock<IStudentService>(); 
        
 
        mockStudentService.Setup(service => service.AllStudents()).ReturnsAsync(new List<StudentDTO>());
        mockStudentService.Setup(service => service.Delete(It.IsAny<int>())).ReturnsAsync(true);


        Services.AddSingleton<IStudentService>(mockStudentService.Object); 
        
    }

    [Fact]
    public void AddButtonShouldDisplay()
    {
        var component = RenderComponent<Students>(); 
        
        
        // finding the s 
        

        // Act: Try to find the "New Student" button
        var addNewStudentButton = component.Find("a.btn.btn-success");

        // Assert: Verify that the button exists and contains the correct text
        Assert.NotNull(addNewStudentButton); // Verify the element is found
        Assert.Equal("New Student", addNewStudentButton.TextContent.Trim());
    }
    
    
    [Fact]
    public void StudentListComponentRendersCorrectly()
    {
        // Arrange
        var mockStudentService = new Mock<IStudentService>();
        var mockStudents = new List<StudentDTO>
        {
            new StudentDTO { Id = 1, FirstName = "Zekaria", LastName = "Mohamed", Age = 26, CourseDto = new CourseDTO { Name = "IKT-206" }, RegistrationDate = new DateTime(2022, 1, 1) },
            new StudentDTO { Id = 2, FirstName = "Kate", LastName = "Kate", Age = 20, CourseDto = new CourseDTO { Name = "IKT-205" }, RegistrationDate = new DateTime(2022, 2, 1) },
          
        };

        mockStudentService.Setup(service => service.AllStudents()).ReturnsAsync(mockStudents);
        Services.AddSingleton<IStudentService>(mockStudentService.Object);

        // Act
        var component = RenderComponent<Students>();

        // Assert
        foreach (var student in mockStudents)
        {
            Assert.Contains(student.FirstName, component.Markup);
            Assert.Contains(student.LastName, component.Markup);
            // we convert the int age to string 
            var studentsAge = student.Age.ToString(); 
            Assert.Contains(studentsAge, component.Markup);
            Assert.Contains(student.CourseDto!.Name, component.Markup);
            // to assert registered date we need to convert ot 
            var formatRegiserteDate = student.RegistrationDate.ToString("dd.MM.yyyy"); 
            Assert.Contains(formatRegiserteDate,  component.Markup); 


        }
    }

    [Fact]
    public async Task AddStudentTest()
    {
        // Arrange
        var mockStudentService = new Mock<IStudentService>();
        var mockCourseService = new Mock<ICourseService>();
        mockCourseService.Setup(service => service.List()).ReturnsAsync(new List<CourseDTO>
        {
            new CourseDTO { Id = 1, Name = "IKT206" },
            new CourseDTO { Id = 2, Name = "IKT205" },
          
        });

        int expectedId = 1; 
        mockStudentService.Setup(service => service.Save(It.IsAny<StudentDTO>()))
            .ReturnsAsync(expectedId);

        using var ctx = new TestContext();
        ctx.Services.AddSingleton<IStudentService>(mockStudentService.Object);
        ctx.Services.AddSingleton<ICourseService>(mockCourseService.Object);

        // Act
        var component = ctx.RenderComponent<Student>(); 
       
        
        component.Find("#firstName").Change("Kate");
        component.Find("#lastName").Change("Test");
        component.Find("#email").Change("teste@uia.no");
        component.Find("#phoneNumber").Change("486768");
        component.Find("#age").Change(23);
        component.Find("select").Change("1");
        component.Find("#Register").Change(DateTime.Today.ToString("yyyy-MM-dd"));
        
        // Set other fields as necessary

     

        component.Find("button[type='submit']").Click();
        // Assert
        mockStudentService.Verify(service => service.Save(It.Is<StudentDTO>(s =>
            s.FirstName == "Kate" &&
                s.LastName == "Test" &&
                s.Email == "teste@uia.no" &&
                s.PhoneNumber == "486768" && 
                s.Age == 23  &&
               s.CourseId == 1 &&
               s.RegistrationDate == DateTime.Today.Date

                )),
                
            Times.Once);
       
        
        var navManager = ctx.Services.GetRequiredService<NavigationManager>();
        var expectedUri = "/";
        var actualUri = new Uri(navManager.Uri).PathAndQuery; // This extracts the path and query from the full URI
        Assert.Equal(expectedUri, actualUri);
    }

  
    
}