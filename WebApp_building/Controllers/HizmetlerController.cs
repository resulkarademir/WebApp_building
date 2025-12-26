using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.Controllers
{
    public class HizmetlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
