using LoggingNlogLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Diagnostics;

namespace LoggingNlogLibrary.Controllers
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
            int num1 = 0;
            int num2 = 5;
            int result;
            try
            {
               result  = num2 / num1;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception,exception.Message);
            }


            _logger.LogInformation("Index page was started.");
            _logger.LogWarning("Warning Error.");
            _logger.LogError("Error Log.");

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