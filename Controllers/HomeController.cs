using Microsoft.AspNetCore.Mvc;

namespace HealthCheck_example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}