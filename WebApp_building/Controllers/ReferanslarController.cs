using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;
using WebApp_building.DAL.Entities;

namespace WebApp_building.Controllers
{
    public class ReferanslarController : Controller
    {
        DataBaseContext _context = new DataBaseContext();
        public IActionResult Index()
        {
            var values = _context.Referanslars.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ReferansEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReferansEkle(Referanslar referanslar)
        {
            _context.Referanslars.Add(referanslar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ReferansGuncelle(int id)
        {
            var referanslar = _context.Referanslars.Find(id);
            return View(referanslar);
        }
        [HttpPost]
        public IActionResult ReferansGuncelle(Referanslar referanslar)
        {
            _context.Referanslars.Update(referanslar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ReferansSil(int id)
        {
            var referanslar = _context.Referanslars.Find(id);
            _context.Referanslars.Remove(referanslar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
