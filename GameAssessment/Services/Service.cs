public class ApiResponse<T>{
    public string Message {get; set;}
    public T Data {get; set;}

    public ApiResponse(string Message, T Data){
        this.Message = Message;
        this.Data = Data;
    }
}