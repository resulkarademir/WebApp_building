using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;

namespace WebApp_building.ViewComponents
{
    public class FeatureComponentPartial:ViewComponent
    {
        DataBaseContext _context = new DataBaseContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}
