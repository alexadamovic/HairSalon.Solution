using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;

    public HomeController(HairSalonContext db)
    {
      _db = db;
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

    [HttpPost("/")]
    public ActionResult Search(string search)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => String.Equals(client.Name, search));

      if (thisClient != null)
      {
        return RedirectToAction("Details", "Clients", new { id = thisClient.ClientId } );
      }
      else
      {
        return RedirectToAction("SearchFail");
      }
    }
  }
}