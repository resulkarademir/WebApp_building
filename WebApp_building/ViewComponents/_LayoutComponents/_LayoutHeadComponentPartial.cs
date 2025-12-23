using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents._LayoutComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
