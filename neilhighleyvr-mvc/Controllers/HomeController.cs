using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using neilhighleyvr_mvc.Models;

namespace neilhighleyvr_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Examples()
        {
            ViewData["Message"] = "Virtual Reality Examples";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "How to contact Neil Highley";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
