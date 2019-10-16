using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Controllers
{
  public class StoreController : Controller
  {
    private readonly RestaurantContext _db;

    public StoreController(RestaurantContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult Index()
    {
      List<Store> model = _db.Stores.ToList();
      return View(model);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Store store)
    {
        _db.Stores.Add(store);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Show(int id)
    {
      Store thisStore = _db.Stores.FirstOrDefault( Stores => Stores.StoreId == id);
      return View(thisStore);
    }
    [HttpGet]
    public ActionResult Delete(int id)
    {
      Store thisStore = _db.Stores.FirstOrDefault( Stores => Stores.StoreId == id);
      return View(thisStore);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult Destroy(int id)
    {
      Store thisStore = _db.Stores.FirstOrDefault( Stores => Stores.StoreId ==  id);
      _db.Stores.Remove(thisStore);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
