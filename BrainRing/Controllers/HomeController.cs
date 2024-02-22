using BrainRing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BrainRing.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View(new TeamAnswer());
        }
    }
}
