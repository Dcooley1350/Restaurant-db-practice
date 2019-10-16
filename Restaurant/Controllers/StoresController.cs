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
    public ActionResult Details(int storeId)
    {
      Store thisStore = _db.Stores.FirstOrDefault( stores => stores.StoreId == storeId);
      return View(thisStore);
    }
  }
}
