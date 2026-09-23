using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lesson9.Models.DataModels;

namespace Lesson9.Controllers
{
    public class VTQMemberController : Controller
    {
        private static List<VTQMember> _vtqMembers = new List<VTQMember>();
        // GET: VTQMemberController
        public ActionResult Index()
        {
            return View(_vtqMembers);
        }

        // GET: VTQMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VTQMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VTQMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VTQMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VTQMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VTQMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VTQMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
