using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeitnerProject.Models;

namespace LeitnerProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Google()
        {
            ViewData["Message"] = "Placeholder for Google Cloud Study Cards";

            return View();
        }

        public IActionResult AWS()
        {
            return View();
        }

        public IActionResult Azure()
        {
            ViewData["Message"] = "Placeholder for Azure Cloud Study Cards";

            return View();
        }
       

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
