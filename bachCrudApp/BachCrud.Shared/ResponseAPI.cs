namespace BlazorCrud.Shared;

public class ResponseAPI<T>
{

    public bool IsSuccess { get; set; }
    public T? Value { get; set; }
    public string? Message { get; set; }
}