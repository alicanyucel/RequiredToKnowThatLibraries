using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
           throw new Exception("An error occured at db.");
        }
        public IActionResult Error2()
        {
            return View();
        }
    }
}
