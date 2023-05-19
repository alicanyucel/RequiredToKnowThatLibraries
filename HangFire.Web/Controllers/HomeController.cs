using HangFire.Web.BackgroundJobs;
using HangFire.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HangFire.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
        public IActionResult SignUp()
        {
            //Member register process that this method.
            FireAndForgetJob.EmailSendToUserJob("1", "Üye Oldu");
            return View();
        }
        public IActionResult PictureSave()
        {
            BackgroundJobs.RecurringJobs.ReportingJob();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PictureSave(IFormFile formFile)
        {
            string newFileName = String.Empty;
            if(formFile!=null && formFile.Length>0)
            {
                newFileName = Guid.NewGuid().ToString()+Path.GetExtension(formFile.FileName);

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Pictures", newFileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                string jobId = BackgroundJobs.DelayedJobs.AddWaterMarkJob(newFileName,"www.mysite.com");

                BackgroundJobs.ContinuationsJobs.WriteWaterMarkStatusJob(jobId, newFileName);
            }

            return View();
        }
    }
}