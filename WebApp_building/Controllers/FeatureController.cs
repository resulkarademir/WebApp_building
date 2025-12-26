using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using WebApp_building.DAL.Context;
using WebApp_building.DAL.Entities;

namespace WebApp_building.Controllers
{
    public class FeatureController : Controller
    {
        DataBaseContext _context= new DataBaseContext();
        public IActionResult Index()
        {
            var values = _context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult FeatureEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeatureEkle(Feature feature)
        {
             _context.Features.Add(feature);
             _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult FeatureSil(int id)
        {
            var feature = _context.Features.Find(id);
            _context.Features.Remove(feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult FeatureGuncelle(int id)
        {
            var feature = _context.Features.Find(id);
            return View(feature);
        }
        [HttpPost]
        public IActionResult FeatureGuncelle(Feature feature)
        {
            _context.Features.Update(feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
