using BlazorUpload.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BlazorUpload.API.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FileController : ControllerBase
    {
        private readonly IStorageService _storageService;

        public FileController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpPost]
        public async Task<string> UploadFile([FromForm] IFormFile file)
        {
            var fileSavePath = await _storageService.SaveFile(file);
            return fileSavePath;
        }
    }
}
