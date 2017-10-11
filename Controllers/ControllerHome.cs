using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesList.Models;

namespace PlacesList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/places/list")]
    public ActionResult PlacesList()
    {
      List<string> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpPost("/places/create")]
    public ActionResult CreatePlace()
    {
      Place newPlace = new Place (Request.Form["placeName"], Request.Form["placePicture"], Request.Form["placeTime"]);
      newPlace.Save();
      return View(newPlace);
    }

    [HttpPost("/places/list/clear")]
    public ActionResult PlacesClear()
    {
      Place.ClearAll();
      return View();
    }
  }
}
