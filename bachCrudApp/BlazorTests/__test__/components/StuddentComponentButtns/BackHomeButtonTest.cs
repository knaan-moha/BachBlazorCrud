using BachCrud.Client.Pages;
using BachCrud.Client.Services.Contracts;
using BachCrud.Shared;
using BlazorCrud.Client.Services;
using BlazorCrud.Shared;
using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlazorTests.__test__.components.StuddentComponentButtns;

public class BackHomeButtonTest : TestContext
{
    [Fact]
    public void BackButtonShouldNavigateHome()
    {
        var mockStudnetService= new Mock<IStudentService>();
        var mockCourseService = new Mock<ICourseService>();

        mockStudnetService.Setup(s => s.Search(It.IsAny<int>())).ReturnsAsync(new StudentDTO()); 
        mockCourseService.Setup(s => s.List()).ReturnsAsync(new List<CourseDTO>());

        Services.AddSingleton<IStudentService>(mockStudnetService.Object);
        Services.AddSingleton<ICourseService>(mockCourseService.Object);

        var component = RenderComponent<Student>();
        
        
        var backButton = component.Find("a.btn.btn-warning"); 
        var expectedUri = "/";
        Assert.Equal(expectedUri, backButton.GetAttribute("href"));


    }
}