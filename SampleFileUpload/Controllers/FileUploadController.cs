using Microsoft.AspNetCore.Mvc;
using SampleFileUpload.Models;
using SampleFileUpload.ViewModel;

namespace SampleFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index(FileUploadViewModel vm)
        {
            vm.SystemFiles = new List<FileCreation>();
            return View(vm);
        }
    }
}
