using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents
{
    public class HizmetlerComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
  
}
