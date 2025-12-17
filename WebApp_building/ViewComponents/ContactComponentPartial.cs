using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents
{
    public class ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
