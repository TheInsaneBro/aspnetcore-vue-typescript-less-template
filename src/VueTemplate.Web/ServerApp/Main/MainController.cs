﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace VueTemplate.Web.ServerApp.Main
{
    public class MainController : Controller
    {
        [HttpGet("{*url}", Name = Routes.Index)]
        public IActionResult Index()
            => View();

        [HttpGet("error", Name = Routes.Error)]
        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}