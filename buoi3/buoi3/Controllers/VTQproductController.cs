using Microsoft.AspNetCore.Mvc;
using buoi3.Models;

namespace Lesson_2.Controllers
{
    public class VTQproductController : Controller
    {
        public IActionResult VTQIndex()
        {
            ViewBag.name = "Vũ Tuấn Quyền";
            ViewData["productVD"] = "Iphone 14 Pro Max";
            TempData["UNI"] = "Đại học Nguyễn Trãi - NTU";

            return View();
        }

        public IActionResult GetProduct()
        {
            var product = new VTQProduct
            {
                ProductID = "2410900066",
                ProductName = "Iphone 14 Pro Max",
                YearRelease = 2006,
                Price = 30000000
            };

            ViewBag.product = product;
            ViewBag.ProductID = product.ProductID;
            ViewBag.ProductName = product.ProductName;
            ViewBag.YearRelease = product.YearRelease;
            ViewBag.Price = product.Price;
            ViewData["product"] = product;

            return View("Product");
        }
    }
}
