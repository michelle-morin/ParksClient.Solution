using Microsoft.AspNetCore.Mvc;
using ParksClient.Models;
using Microsoft.AspNetCore.Authorization;

namespace ParksClient.Controllers
{
  [Authorize]
  public class ParksController : Controller
  {
    [AllowAnonymous]
    public IActionResult Index()
    {
      var allParks = Park.GetParks();
      return View(allParks);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Park park)
    {
      Park.Post(park);
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    public IActionResult Search(string name, string agency, string state, bool? campsites)
    {
      var searchResults = Park.Search(name, agency, state, campsites);
      return View("Index", searchResults);
    }

    [AllowAnonymous]
    public IActionResult Details(int id)
    {
      var park = Park.GetDetails(id);
      return View(park);
    }

    public IActionResult Edit(int id)
    {
      var park = Park.GetDetails(id);
      return View(park);
    }

    [HttpPost]
    public IActionResult Details(int id, Park park)
    {
      park.ParkId = id;
      Park.Put(park);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Park.Delete(id);
      return RedirectToAction("Index");
    }
  }
}