namespace Recam.Api.Responses;

public class ApiResponse<T>
{
    public bool Success {get; set;}

    public required string Message {get; set;}

    public T? Data {get; set;}

    public ICollection<string> Errors {get; set;} = new List<string>();

    public static ApiResponse<T> Ok(T data)
    {
        return new ApiResponse<T>
        {
            Success = true,
            Message = "Ok",
            Data = data
        };
    }

    public static ApiResponse<T> Fail(string message)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Message = message
        };
    }

    
}
