using Microsoft.AspNetCore.Mvc;

namespace WebApp_building.ViewComponents._LayoutComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
