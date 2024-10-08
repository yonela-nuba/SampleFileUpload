using Microsoft.AspNetCore.Mvc;
using SampleFileUpload.Data;
using SampleFileUpload.Models;
using SampleFileUpload.ViewModel;

namespace SampleFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        //Add ApplicationDbContext here
        public readonly ApplicationDbContext _context;
        public FileUploadController(ApplicationDbContext context)
        {
                _context = context;
        }
        [HttpGet]
        public IActionResult Index(FileUploadViewModel vm)
        {
            vm.SystemFiles = new List<FileCreation>();
            return View(vm);
        }

        [HttpPost]
        public IActionResult UploadFile(FileUploadViewModel vm, IFormFile file)
        {
            //var filename = file.FileName;
            var filename = $"{file.FileName}_{DateTime.Now.ToString("yyyymmddhhmmss")}";
            var uploadedfile = new FileCreation
            {
                UploadedOn = DateTime.Now,
                UploadedBy = "Yonela Nuba",
                FileType = file.ContentType,
                FileName = filename,
                Description = vm.Description,
                FilePath = vm.FilePath,
                //Extension = file.

            };
            return View(vm);
        }
    }
}
