using System.Net.Http.Json;
using BachCrud.Client.Services.Contracts;
using BlazorCrud.Shared;

namespace BachCrud.Client.Services;

public class CourseService : ICourseService
{
    private readonly HttpClient _httpClient;


    public CourseService(HttpClient httpClient)
    {
        _httpClient = httpClient; 
    }
    public async Task<List<CourseDTO>> List()
    {
        
        var result = await _httpClient.GetFromJsonAsync<ResponseAPI<List<CourseDTO>>>("api/Course/AllCourses");

        if (result!.IsSuccess)
        {
            return result.Value!;
        }
        else
        {
            throw new Exception(result.Message); 
        }
    }
}