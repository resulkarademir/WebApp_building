using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApp_building.DAL.Context;

namespace WebApp_building.ViewComponents
{
    public class ReferanslarComponentPartial: ViewComponent
    {
        DataBaseContext _context= new DataBaseContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Referanslars.ToList();
            return View(values);
        }
    }
}
