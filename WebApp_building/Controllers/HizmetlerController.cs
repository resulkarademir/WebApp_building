using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;
using WebApp_building.DAL.Entities;

namespace WebApp_building.Controllers
{
    public class HizmetlerController : Controller
    {
        DataBaseContext _context = new DataBaseContext();
        public IActionResult Index()
        {
            var values = _context.Hizmetlers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult HizmetEkle()
        {
          return View();

        }

        [HttpPost]
        public IActionResult HizmetEkle(Hizmetler hizmetler)
        {
            _context.Hizmetlers.Add(hizmetler);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult HizmetSil(int id)
        {
            var hizmetler = _context.Hizmetlers.Find(id);
            _context.Hizmetlers.Remove(hizmetler);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult HizmetGuncelle(int id)
        {
            var hizmetler = _context.Hizmetlers.Find(id);
            return View(hizmetler);
        }
        [HttpPost]
        public IActionResult HizmetGuncelle(Hizmetler hizmetler)
        {
            _context.Hizmetlers.Update(hizmetler);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
