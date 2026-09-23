using Microsoft.AspNetCore.Mvc;

namespace Lesson9.Controllers
{
    public class VTQAboutController : Controller
    {
        public IActionResult About()
        {
            return View("~/Views/VTQAbout.cshtml");
        }
    }
}
