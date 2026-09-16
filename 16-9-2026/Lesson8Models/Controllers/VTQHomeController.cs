using System.Diagnostics;
using Lesson8Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson8Models.Controllers
{
    public class VTQHomeController : Controller
    {
        private readonly ILogger<VTQHomeController> _logger;

        public VTQHomeController(ILogger<VTQHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult VTQIndex()
        {
            return View();
        }

        public IActionResult VTQPrivacy()
        {
            return View();
        }
        public IActionResult VTQAbout()
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
