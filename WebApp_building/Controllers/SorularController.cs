using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;
using WebApp_building.DAL.Entities;

namespace WebApp_building.Controllers
{
    public class SorularController : Controller
    {
        DataBaseContext _context = new DataBaseContext();
        public IActionResult Index()
        {
            var values = _context.Asks.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SoruEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SoruEkle(Ask ask)
        {
            _context.Asks.Add(ask);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult SoruGuncelle(int id)
        {
            var ask = _context.Asks.Find(id);
            return View(ask);
        }
        [HttpPost]
        public IActionResult SoruGuncelle(Ask ask)
        {
            _context.Asks.Update(ask);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult SoruSil(int id)
        {
            var ask = _context.Asks.Find(id);
            _context.Asks.Remove(ask);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
