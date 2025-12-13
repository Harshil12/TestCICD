using System.Diagnostics;
using Employee_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management.Controllers
{
    public class HomeController : Controller
    {
        public IEmployee Empyee { get; }

        public HomeController(IEmployee empyee)
        {
            Empyee = empyee;
        }
        public IActionResult Index()
        {
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
