using Microsoft.AspNetCore.Mvc;
using SampleFileUpload.Models;
using System.Diagnostics;

namespace SampleFileUpload.Controllers
{
    public class HomeController : Controller
    {

        private readonly IWebHostEnvironment _webHost;

        public HomeController(IWebHostEnvironment webHost)
        {
                _webHost = webHost;
        }
       // private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Index(IFormFile file)
        {
            string uploadsFolder = Path.Combine(_webHost.WebRootPath,"uploads");

            if(!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string fileName = Path.GetFileName(file.FileName);
            string fileSavePath = Path.Combine(uploadsFolder,fileName);

            using(FileStream stream = new FileStream(fileSavePath, FileMode.Create)) 
            {
                await file.CopyToAsync(stream);
            }

            ViewBag.Message = fileName + " Uploaded successfully!";

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
