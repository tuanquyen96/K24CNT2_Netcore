using Microsoft.AspNetCore.Mvc;

namespace VTQLab04.Controllers
{
    public class VTQHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VTQPrivacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
