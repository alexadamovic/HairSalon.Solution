using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _clientsDb;

    public HomeController(HairSalonContext db)
    {
      _clientsDb = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult SearchFail()
    {
      return View();
    }

    [HttpPost, ActionName("Search")]
    public ActionResult Search(string search)
    {
      var thisClient = _clientsDb.Clients.FirstOrDefault(client => String.Equals(client.Name, search));

      if (thisClient != null)
      {
        return RedirectToAction("Details", "Clients", new { id = thisClient.ClientId } );
      }
      else
      {
        // Search unsuccessful return to failure page
        return RedirectToAction("Index");
      }
    }
  }
}