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


public class StudentAddTest : TestContext
{
   [Fact]
    public async Task ShouldAddStudent()
    {
        // mocking the service for the student and courses 
        var mockStudentService = new Mock<IStudentService>();
        var mockCourseService = new Mock<ICourseService>();

        mockCourseService.Setup(service => service.List()).ReturnsAsync(new List<CourseDTO>
        {
            new CourseDTO { Id = 1, Name = "IKT206" },
            new CourseDTO { Id = 2, Name = "IKT205" }
        });

        int newStudentId = 1;

        mockStudentService.Setup(service => service.Save(It.IsAny<StudentDTO>())).ReturnsAsync(newStudentId);
        
        
        // register for instance of the service 
        using var ctx = new TestContext();
        ctx.Services.AddSingleton<IStudentService>(mockStudentService.Object);
        ctx.Services.AddSingleton<ICourseService>(mockCourseService.Object); 
        
        // act 
        var component = ctx.RenderComponent<Student>(); 
        
        component.Find("#firstName").Change("Kate");
        component.Find("#lastName").Change("Test");
        component.Find("#email").Change("teste@uia.no");
        component.Find("#phoneNumber").Change("486768");
        component.Find("#age").Change(23);
        component.Find("select").Change("1");
        component.Find("#Register").Change(DateTime.Today.ToString("yyyy-MM-dd"));

        // finding the submit button 
        
        component.Find("button[type='submit']").Click();

        
        
        // making verifying with Assert 
        
        mockStudentService.Verify(service=> service.Save(It.Is<StudentDTO>(s=>
            s.FirstName == "Kate" &&
            s.LastName == "Test" &&
            s.Email == "teste@uia.no" &&
            s.PhoneNumber == "486768" && 
            s.Age == 23  &&
            s.CourseId == 1 &&
            s.RegistrationDate == DateTime.Today.Date
            
            )), 
            
            Times.Once);
        // config for the navigation 

        var navManger = ctx.Services.GetRequiredService<NavigationManager>();
        var expectedUri = "/";
        var actualUri = new Uri(navManger.Uri).PathAndQuery; 
        Assert.Equal(expectedUri, actualUri);
        
    }
    
}