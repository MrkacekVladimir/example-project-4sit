using System.Diagnostics;
using ExampleProjectSitari.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProjectSitari.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //TODO: tady taky
            _logger = logger;
        }

        public IActionResult Index()
        {
            //TODO: tady musím to změnit
            ViewBag.Test = true;
            ViewBag.Message = "Ahoj";            
            return View();
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
