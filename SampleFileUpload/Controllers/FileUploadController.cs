using Microsoft.AspNetCore.Mvc;
using SampleFileUpload.Models;
using SampleFileUpload.ViewModel;

namespace SampleFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        //Add ApplicationDbContext here

        public IActionResult Index(FileUploadViewModel vm, IFormFile file)
        {
            vm.SystemFiles = new List<FileCreation>();
            return View(vm);
        }
    }
}
