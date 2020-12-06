using Microsoft.AspNetCore.Mvc;

namespace LandingPage_ASP.Net_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
