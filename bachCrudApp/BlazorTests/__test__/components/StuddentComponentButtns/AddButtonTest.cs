using BachCrud.Client.Pages;
using BlazorCrud.Client.Services;
using BlazorCrud.Shared;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlazorTests.__test__.components.StuddentComponentButtns;

public class AddButtonTest : TestContext

{
    [Fact]
    public void AddButtonShouldDisplay()
    {
        var mockStudentService = new Mock<IStudentService>();

        mockStudentService.Setup(s => s.AllStudents()).ReturnsAsync(new List<StudentDTO>());

        Services.AddSingleton<IStudentService>(mockStudentService.Object);

        var component = RenderComponent<Students>(); 
        
        var addNewStudentButton = component.Find("a.btn.btn-success");
        
        Assert.NotNull(addNewStudentButton); 
        Assert.Equal("New Student", addNewStudentButton.TextContent.Trim());

    }
    
}