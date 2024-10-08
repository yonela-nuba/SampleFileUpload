using Microsoft.AspNetCore.Mvc;

namespace SampleFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", "FileUpload");
        }
    }
}
