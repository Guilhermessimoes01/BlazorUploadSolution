namespace BlazorUpload.API.Services.Interfaces
{
    public interface IStorageService
    {
        Task<string> SaveFile(IFormFile file);
    }
}
