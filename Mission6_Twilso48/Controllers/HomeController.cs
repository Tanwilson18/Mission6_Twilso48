using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_Twilso48.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Twilso48.Controllers
{
    public class HomeController : Controller
    {
        // constructor  
        private readonly ILogger<HomeController> _logger;
        private context blahcontext { get; set; }

        public HomeController(ILogger<HomeController> logger, context someName)
        {
            _logger = logger;
            blahcontext = someName;
        }
        //index route 
        public IActionResult Index()
        {
            return View();
        }
        // podcast route
        public IActionResult Podcast()
        {
            return View();
        }
        //get page route
        [HttpGet]
        public IActionResult Movie()
        {
            return View();
        }

        //post page route
        [HttpPost]
        public IActionResult Movie(applicationResponse ar)
        {
            blahcontext.Add(ar);
            blahcontext.SaveChanges();
            return View("Confirmation", ar);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
