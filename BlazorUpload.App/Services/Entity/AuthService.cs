using System.Threading.Tasks;
using BlazorUpload.App.Services.Interface;

namespace BlazorUpload.App.Services.Entity
{
    public class AuthService : IAuthService
    {
        public async Task<bool> Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                await Task.Delay(500);
                return true;
            }
            return false;
        }

        public Task Logout()
        {
            return Task.CompletedTask;
        }
    }
}
