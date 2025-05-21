using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Poteri_Davleniya.Models;
using Poteri_Davleniya.Data;

namespace Poteri_Davleniya.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PoteriContext _context;

        public HomeController(ILogger<HomeController> logger, PoteriContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var variants = _context.Variants.FirstOrDefault();
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
