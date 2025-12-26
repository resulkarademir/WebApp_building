using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
