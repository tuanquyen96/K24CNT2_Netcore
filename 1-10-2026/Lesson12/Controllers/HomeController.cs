using Microsoft.AspNetCore.Mvc;

namespace VTQNetCoreCrud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
