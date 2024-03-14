namespace BachCrud.Shared;

public class ResponseApi<T>
{

    public bool IsSuccess { get; set; }
    public T? Value { get; set; }
    public string? Message { get; set; }
}