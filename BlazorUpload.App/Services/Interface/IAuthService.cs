namespace BlazorUpload.App.Services.Interface
{
    public interface IAuthService
    {
        Task<bool> Login(string username, string password);
        Task Logout();
    }
}
