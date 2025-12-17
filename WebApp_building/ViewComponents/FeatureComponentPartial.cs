using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents
{
    public class FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
