using Microsoft.AspNetCore.Mvc;

namespace RideHubAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("<h1>RideHubBackend is up 🚀</h1>", "text/html");
        }

        [HttpGet("api/home/test")]
        public IActionResult GetTest()
        {
            return Ok(new { message = "CORS is working!" });
        }
    }
}
