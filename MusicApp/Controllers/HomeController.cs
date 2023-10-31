﻿using Microsoft.AspNetCore.Mvc;
using MusicApp.Models;
using System.Diagnostics;

namespace MusicApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search (string searchText)
        {
            // call api method to search tracks
            var tracks = new List<object>();
            return View(tracks);
        }
    }
}