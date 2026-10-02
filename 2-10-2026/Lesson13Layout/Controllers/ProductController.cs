using Microsoft.AspNetCore.Mvc;

namespace Lesson13Layout.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string keyword)
        {
            ViewData["Keyword"] = keyword;
            return View();
        }

        public IActionResult Hots(int id)
        {
            ViewData["ProductId"] = id;
            return View();
        }
    }
}
