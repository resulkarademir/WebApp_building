using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;

namespace WebApp_building.ViewComponents
{
    public class NedenBizComponentPartial:ViewComponent
    {
        DataBaseContext _context = new DataBaseContext();

        public IViewComponentResult Invoke()
        {
            var values = _context.NedenBizs.ToList();
            return View(values);
        }
    }
 
}
