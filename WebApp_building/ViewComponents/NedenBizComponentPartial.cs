using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents
{
    public class NedenBizComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
 
}
