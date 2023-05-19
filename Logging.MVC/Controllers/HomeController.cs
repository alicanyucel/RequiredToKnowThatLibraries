using Logging.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Logging.MVC.Controllers
{
    public class HomeController : Controller
    {
        //I.Way
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //II.Way
        private readonly ILoggerFactory _loggerFactory;
        public HomeController(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public IActionResult Index()
        {
           var _logger = _loggerFactory.CreateLogger("HomeClass");

            _logger.LogTrace("Entered Index Page.");
            _logger.LogDebug("Entered Index Page.");
            _logger.LogInformation("Entered Index Page.");
            _logger.LogWarning("Entered Index Page.");
            _logger.LogError("Entered Index Page.");
            _logger.LogCritical("Entered Index Page.");
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