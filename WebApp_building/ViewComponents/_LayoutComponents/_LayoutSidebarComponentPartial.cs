using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents._LayoutComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
