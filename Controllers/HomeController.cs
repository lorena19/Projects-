using System; 
using Microsoft.AspNetCore.Mvc; 

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]

        public IActionResult Projects()
        {
            return View(); 
        }

        [HttpGet("contact")]

        public IActionResult Contact()
        {
            return View(); 
        }

    }
}