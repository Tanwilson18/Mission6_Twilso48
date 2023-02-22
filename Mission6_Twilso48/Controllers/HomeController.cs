using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
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

        public HomeController( context someName)
        {
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
            ViewBag.Category = blahcontext.Category.ToList();

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
        [HttpGet]
        public IActionResult WaitList()
        {
            var applications = blahcontext.Responses.Include(y =>y.Category)
                .OrderBy(x => x.Title).ToList();
            return View(applications);
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
