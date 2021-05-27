using AzureBlobStorage.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureBlobStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IStorageService _storageService;

        public FileUploadController(IStorageService storageService)
        {
            _storageService = storageService;
        }
        public IActionResult Get()
        {
            return Ok("File Upload api running...");
        }

        [HttpPost]
        [Route("upload")]
        public IActionResult Upload(IFormFile file)
        {
            _storageService.Upload(file);
            return Ok();
        }
    }
}
