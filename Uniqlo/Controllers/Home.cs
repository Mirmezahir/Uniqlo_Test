﻿using Microsoft.AspNetCore.Mvc;

namespace Uniqlo.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
 
    }
}
