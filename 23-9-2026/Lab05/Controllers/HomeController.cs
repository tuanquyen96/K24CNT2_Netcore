using Microsoft.AspNetCore.Mvc;

namespace Lab05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => RedirectToAction("Index", "Account");
        public IActionResult Error() => View();
    }
}
