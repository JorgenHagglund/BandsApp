﻿using BandsApp.Web.Services;
using BandsApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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

        var albums = JsonSerializer.Deserialize<Dictionary<string, List<Album>>>(System.IO.File.ReadAllText("albums.json"));

        if (albums != null)
        {
            band.Albums = albums
            .SingleOrDefault(a => a.Key == band.Name)
            .Value
            .ToList()
            .OrderBy(a => a.Year)
            .ToArray() ?? [];
        }

        return View(band);
    }
}
