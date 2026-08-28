using Microsoft.AspNetCore.Mvc;
using Lesson3.Models;

namespace Lesson3.Controllers
{
    [Route("/danh-sach-san-pham")]
    public class VTQProductController : Controller
    {
        //Mock data
        private readonly List<VTQProduct> _products = new()
        {
            new()
            {
                VTQProductId = "VTQ001",
                VTQProductName = "Laptop Dell Inspiron 15",
                VTQYearRelease = 2024,
                VTQPrice = 15990000m
            },
            new()
            {
                VTQProductId = "VTQ002",
                VTQProductName = "Laptop HP Pavilion 14",
                VTQYearRelease = 2024,
                VTQPrice = 17490000m
            },
            new()
            {
                VTQProductId = "VTQ003",
                VTQProductName = "iPhone 15",
                VTQYearRelease = 2023,
                VTQPrice = 21990000m
            },
            new()
            {
                VTQProductId = "VTQ004",
                VTQProductName = "Samsung Galaxy S24",
                VTQYearRelease = 2024,
                VTQPrice = 19990000m
            },
            new()
            {
                VTQProductId = "VTQ005",
                VTQProductName = "iPad Air M2",
                VTQYearRelease = 2024,
                VTQPrice = 16990000m
            },
            new()
            {
                VTQProductId = "VTQ006",
                VTQProductName = "Tai nghe Sony WH-1000XM5",
                VTQYearRelease = 2022,
                VTQPrice = 8490000m
            },
            new()
            {
                VTQProductId = "VTQ007",
                VTQProductName = "Apple Watch Series 9",
                VTQYearRelease = 2023,
                VTQPrice = 10990000m
            },
            new()
            {
                VTQProductId = "VTQ008",
                VTQProductName = "Màn hình LG UltraGear 27",
                VTQYearRelease = 2024,
                VTQPrice = 7990000m
            },
            new()
            {
                VTQProductId = "VTQ009",
                VTQProductName = "Bàn phím cơ Keychron K2",
                VTQYearRelease = 2023,
                VTQPrice = 2190000m
            },
            new()
            {
                VTQProductId = "VTQ010",
                VTQProductName = "Chuột Logitech MX Master 3S",
                VTQYearRelease = 2022,
                VTQPrice = 1990000m
            }
        };

        public IActionResult Index()
        {
            return View(_products);
        }
        //Collection => View
        [HttpGet("/danh-sach-san-pham")]    
        public IActionResult VTQGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }
    }
}
