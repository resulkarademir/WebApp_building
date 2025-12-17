using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents
{
    public class ReferanslarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
