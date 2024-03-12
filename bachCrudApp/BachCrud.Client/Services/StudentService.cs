using System.Net.Http.Json;
using BlazorCrud.Client.Services;
using BlazorCrud.Shared;

namespace BachCrud.Client.Services;

public class StudentService : IStudentService
{
    private readonly HttpClient _httpClient;

    public StudentService(HttpClient httpClient)
    {
        _httpClient = httpClient; 
    }
    
    
    
    public async Task<List<StudentDTO>> AllStudents()
    {


        var result = await _httpClient.GetFromJsonAsync<ResponseAPI<List<StudentDTO>>>("api/Student/AllStudents");


        if (result!.IsSuccess)
        {
            return result.Value!; 

        }
        else
        {
            throw new Exception(result.Message);
        }
    }

    public async Task<StudentDTO> Search(int id)
    {
        var result = await _httpClient.GetFromJsonAsync<ResponseAPI<StudentDTO>>($"api/Student/Search/{id}");
        if (result!.IsSuccess)
        {
            return result.Value!; 
            
        }
        else
        {
            throw new Exception(result.Message); 
            
        }
    }

    public async Task<int> Save(StudentDTO studentDto)
    {
        var result = await _httpClient.PostAsJsonAsync("api/Student/Save", studentDto);
        var response = await result.Content.ReadFromJsonAsync < ResponseAPI<int>>();

        if (response!.IsSuccess)
        {
            return response.Value;
        }
        else
        {
            throw new Exception(response.Message); 
        }
    }

    public async Task<int> Edit(StudentDTO studentDto)
    {
        var result = await _httpClient.PutAsJsonAsync($"api/Student/Edit/{studentDto.Id}", studentDto);
        var response = await result.Content.ReadFromJsonAsync<ResponseAPI<int>>();

        if (response!.IsSuccess)
        {
            return response.Value; 

        }
        else
        {
            throw new Exception(response.Message); 
            
        }

    }  
    
    

    public async Task<bool> Delete(int id)
    {
        var result = await _httpClient.DeleteAsync($"api/Student/Delete/{id}");
        if (result.IsSuccessStatusCode)
        {
            return true;
        }
        else
        {
            var responseApi = await result.Content.ReadFromJsonAsync<ResponseAPI<int>>();
            responseApi!.Message= "An error occurred while trying to delete the student";
            return false;
        }
    }
}