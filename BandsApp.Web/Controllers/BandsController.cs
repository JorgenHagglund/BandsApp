using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Controllers;

public class BandsController : Controller
{
    BandService bandService = new();

    [Route("")]
    public IActionResult Index()
    {
        var bands = bandService.GetAllBands();
        return View(bands);
    }

    [Route("details/{id:int}")]
    public IActionResult Details(int id)
    {
        var band = bandService.GetBandById(id);
        if (band == null)
        {
            return NotFound();
        }
        return View(band);
    }
}
