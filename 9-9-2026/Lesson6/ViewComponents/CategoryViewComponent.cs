using Microsoft.AspNetCore.Mvc;
using Lesson6.Models;


namespace Lesson6.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            var categories = new List<Category>
            {
                new Category { CategoryId = 1, Name = "Category 1", Status = true },
                new Category { CategoryId = 2, Name = "Category 2", Status = true },
                new Category { CategoryId = 3, Name = "Category 3", Status = false },
                new Category { CategoryId = 4, Name = "Category 4", Status = true },
            };
            n = n ?? 0;
            var search = categories.Where(x=>x.CategoryId>=n).ToList();
            return View(search);
        }
    }
}
