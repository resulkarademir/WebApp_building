using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;
using WebApp_building.DAL.Entities;

namespace WebApp_building.Controllers
{
    public class AboutController : Controller
    {
        DataBaseContext _context=new DataBaseContext();
        public IActionResult Index()
        {
            var values = _context.Hakkimizdas.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AboutEkle()
        {
           return View();
        }

        [HttpPost]
        public IActionResult AboutEkle(Hakkimizda hakkimizda)
        {
            _context.Hakkimizdas.Add(hakkimizda);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AboutSil(int id)
        {
            var hakkimizda = _context.Hakkimizdas.Find(id);
            _context.Hakkimizdas.Remove(hakkimizda);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AboutGuncelle(int id)
        {
            var hakkimizda = _context.Hakkimizdas.Find(id);
            return View(hakkimizda);
        }

        [HttpPost]
        public IActionResult AboutGuncelle(Hakkimizda hakkimizda)
        {
            _context.Hakkimizdas.Update(hakkimizda);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
