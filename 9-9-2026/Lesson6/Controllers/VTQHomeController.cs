using System.Diagnostics;
using Lesson6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6.Controllers
{
    public class VTQHomeController : Controller
    {
        private readonly ILogger<VTQHomeController> _logger;

        public VTQHomeController(ILogger<VTQHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
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
