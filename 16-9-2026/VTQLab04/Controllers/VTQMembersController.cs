using Microsoft.AspNetCore.Mvc;
using VTQLab04.Models;

namespace VTQLab04.Controllers
{
    public class VTQMembersController : Controller
    {
        public IActionResult Index()
        {
            var members = DataLocal.GetVTQMembers();
            return View(members);
        }

        public IActionResult Details(string id)
        {
            var member = DataLocal.GetVTQMemberById(id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        public IActionResult Create()
        {
            var member = new VTQMember
            {
                VTQMemberId = Guid.NewGuid().ToString()
            };
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VTQMember model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatar", fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    model.Avatar = "images/avatar/" + fileName;
                }

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (DataLocal._members.Any(x => x.VTQMemberId == model.VTQMemberId))
                {
                    model.VTQMemberId = Guid.NewGuid().ToString();
                }

                DataLocal._members.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public IActionResult Edit(string id)
        {
            var member = DataLocal.GetVTQMemberById(id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, VTQMember model)
        {
            try
            {
                var member = DataLocal.GetVTQMemberById(id);
                if (member == null)
                {
                    return NotFound();
                }

                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatar", fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    model.Avatar = "images/avatar/" + fileName;
                }
                else
                {
                    model.Avatar = member.Avatar;
                }

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                for (int i = 0; i < DataLocal._members.Count; i++)
                {
                    if (DataLocal._members[i].VTQMemberId == id)
                    {
                        model.VTQMemberId = id;
                        DataLocal._members[i] = model;
                        break;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public IActionResult Delete(string id)
        {
            var member = DataLocal.GetVTQMemberById(id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id, VTQMember model)
        {
            try
            {
                for (int i = 0; i < DataLocal._members.Count; i++)
                {
                    if (DataLocal._members[i].VTQMemberId == id)
                    {
                        DataLocal._members.RemoveAt(i);
                        break;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
