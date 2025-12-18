using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;

namespace WebApp_building.ViewComponents
{
    public class HakkimizdaComponentPartial:ViewComponent
    {
        DataBaseContext _context = new DataBaseContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Hakkimizdas.ToList();
            return View(values);
        }
    }
}
