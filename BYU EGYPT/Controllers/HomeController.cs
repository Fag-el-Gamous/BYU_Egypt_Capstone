﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BYU_EGYPT.Models;

namespace BYU_EGYPT.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ByuEgyptDbContext egyptDbContext = new ByuEgyptDbContext();
        
        //var testTableList = egyptDbContext.TestTables.ToList();
        var databaseList = egyptDbContext.Crania.ToList();

        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Data()
    {
        return View();
    }

    public IActionResult Search()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

