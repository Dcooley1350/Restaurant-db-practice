using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult Search(string type, string search)
    {
      switch (type)
      {
        case "cuisine":

        return View();
        
        case "restaurant":

          return View();
          
        default:

          return View();
      }
    }
    
  }
}