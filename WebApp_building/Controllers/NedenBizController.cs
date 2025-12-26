using Microsoft.AspNetCore.Mvc;
using WebApp_building.DAL.Context;
using WebApp_building.DAL.Entities;

namespace WebApp_building.Controllers
{
    public class NedenBizController : Controller
    {
        DataBaseContext _context= new DataBaseContext();
        public IActionResult Index()
        {
            var values = _context.NedenBizs.ToList();

            return View(values);
        }


        public IActionResult NedenBizSil(int id)
        {
            var nedenBiz = _context.NedenBizs.Find(id);
            _context.NedenBizs.Remove(nedenBiz);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult NedenBizEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NedenBizEkle(NedenBiz nedenBiz)
        {
            _context.NedenBizs.Add(nedenBiz);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult NedenBizGuncelle(int id)
        {
            var nedenBiz = _context.NedenBizs.Find(id);
            return View(nedenBiz);
        }
        [HttpPost]
        public IActionResult NedenBizGuncelle(NedenBiz nedenBiz)
        {
            _context.NedenBizs.Update(nedenBiz);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
