using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(new {Id=1,Name="kalem",Price=20 });
        }
        [HttpGet("{name}")] //With this statement, we can take parameter at route.
        public IActionResult GetProduct(string name) 
        {
            return Ok(name);
        }

        [HttpPost]
        public IActionResult AddProduct()
        {
            return Ok(new {Status="Success" });
        }
        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }
    }
}
