using BachCrud.Client.Pages;
using BachCrud.Client.Services.Contracts;
using BlazorCrud.Client.Services;
using BlazorCrud.Shared;
using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlazorTests.__test__.components;

public class StudentUpdateTest : TestContext
{
    [Fact]

     public async Task ShouldUpdateStudent()
    {
        // Arrange
        var mockStudentService = new Mock<IStudentService>();
        var mockCourseService = new Mock<ICourseService>();
        var existingStudent = new StudentDTO
        {
            Id = 1,
            FirstName = "Zekaria",
            LastName = "mohamed",
            Email = "mo@uia.no",
            PhoneNumber = "454545",
            Age = 27,
            CourseId = 2,
            RegistrationDate = DateTime.Today.AddDays(-1)
        };

        mockCourseService.Setup(service => service.List()).ReturnsAsync(new List<CourseDTO>
        {
            new CourseDTO { Id = 1, Name = "IKT206" },
            new CourseDTO { Id = 2, Name = "IKT205" }
        });

        mockStudentService.Setup(service => service.Search(existingStudent.Id)).ReturnsAsync(existingStudent);
        mockStudentService.Setup(service => service.Edit(It.IsAny<StudentDTO>())).ReturnsAsync(existingStudent.Id);
        
        
        
        Services.AddSingleton<IStudentService>(mockStudentService.Object);
        Services.AddSingleton<ICourseService>(mockCourseService.Object);

        // Act
        var component = RenderComponent<Student>(parameters => parameters.Add(p => p.studentId, existingStudent.Id));
        
        component.Find("#firstName").Change("kate");
        component.Find("#lastName").Change("TestUpdate");
        component.Find("#email").Change("testUpdate@uia,no");
        component.Find("#phoneNumber").Change("47474");
        component.Find("#age").Change(21);
        component.Find("select").Change("1"); 
        component.Find("#Register").Change(DateTime.Today.ToString("yyyy-MM-dd"));
        
        component.Find("button[type='submit']").Click();

        // Assert
        mockStudentService.Verify(service => service.Edit(It.Is<StudentDTO>(s =>
                s.Id == existingStudent.Id &&
                s.FirstName == "kate" &&
                s.LastName == "TestUpdate" &&
                s.Email == "testUpdate@uia,no" &&
                s.PhoneNumber == "47474" &&
                s.Age == 21 &&
                s.CourseId == 1 &&
                s.RegistrationDate == DateTime.Today)),
            Times.Once);
        
        var navManger = Services.GetRequiredService<NavigationManager>();
        var expectedUri = "/";
        var actualUri = new Uri(navManger.Uri).PathAndQuery; 
        Assert.Equal(expectedUri, actualUri);
    }
    
}