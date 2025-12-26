using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.Controllers
{
    public class SorularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
