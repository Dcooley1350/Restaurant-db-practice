using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Controllers
{
    public class CuisineController : Controller{
        
        private readonly RestaurantContext _db;

        public CuisineController(RestaurantContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Cuisine> model = _db.Cuisines.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Cuisine cuisine)
        {
            _db.Cuisines.Add(cuisine);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Show(int id)
        {
        Cuisine thisDish = _db.Cuisines.FirstOrDefault( Cuisine => Cuisine.CuisineId == id);
        return View(thisDish);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
        Cuisine thisDish = _db.Cuisines.FirstOrDefault( Cuisine => Cuisine.CuisineId == id);
        return View(thisDish);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Destroy(int id)
        {
        Cuisine thisDish = _db.Cuisines.FirstOrDefault( Cuisine => Cuisine.CuisineId ==  id);
        _db.Cuisines.Remove(thisDish);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
        Cuisine thisDish = _db.Cuisines.FirstOrDefault( Cuisine => Cuisine.CuisineId == id);
        return View(thisDish);
        }
        [HttpPost, ActionName("Update")]
        public ActionResult Update(Cuisine cuisine)
        {
        _db.Entry(cuisine).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
        }

    }
}