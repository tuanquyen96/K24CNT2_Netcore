using Microsoft.AspNetCore.Mvc;
using Lesson8Models.Models;

namespace Lesson8Models.Controllers
{
    public class VTQMemberController : Controller
    {
        //MOCKDATA - VTQMember
        private static List<VTQMember> _member = new List<VTQMember>
        {
            new VTQMember
    {
        VTQMemberId = Guid.NewGuid().ToString(),
        VTQUserName = "Adudu",
        VTQPassword = "123456",
        VTQFullName = "Vu Tuan Quyen",
        VTQEmail = "radahotga1@gmail.com"
    },
            new VTQMember
    {
        VTQMemberId = Guid.NewGuid().ToString(),
        VTQUserName = "quyen02",
        VTQPassword = "123456",
        VTQFullName = "Tran Van Nam",
        VTQEmail = "nam02@gmail.com"
    },
            new VTQMember
    {
        VTQMemberId = Guid.NewGuid().ToString(),
        VTQUserName = "quyen03",
        VTQPassword = "123456",
        VTQFullName = "Le Minh Anh",
        VTQEmail = "minhanh03@gmail.com"
    },
            new VTQMember
    {
        VTQMemberId = Guid.NewGuid().ToString(),
        VTQUserName = "quyen04",
        VTQPassword = "123456",
        VTQFullName = "Pham Hoang Long",
        VTQEmail = "long04@gmail.com"
    },
            new VTQMember
    {
        VTQMemberId = Guid.NewGuid().ToString(),
        VTQUserName = "quyen05",
        VTQPassword = "123456",
        VTQFullName = "Do Thi Hoa",
        VTQEmail = "hoa05@gmail.com"
    }
        };
        //Get danh sách thành viên
        public IActionResult Index()
        {   return View(_member); 
        }
        [HttpGet]
        public IActionResult VTQCreate()
        {
            var member = new VTQMember();
            return View("VTQCreate", member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VTQCreate(VTQMember member)
        {
            if (!ModelState.IsValid)
            {
                return View("VTQCreate", member);
            }

            member.VTQMemberId = Guid.NewGuid().ToString();
            _member.Add(member);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult VTQEdit(string id)
        {
            var member = _member.FirstOrDefault(x => x.VTQMemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            return View("VTQEdit", member);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VTQEdit(string id, VTQMember vtqMember)
        {
            if (!ModelState.IsValid)
            {
                return View("VTQEdit", vtqMember);
            }

            var member = _member.FirstOrDefault(x => x.VTQMemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            member.VTQUserName = vtqMember.VTQUserName;
            member.VTQPassword = vtqMember.VTQPassword;
            member.VTQFullName = vtqMember.VTQFullName;
            member.VTQEmail = vtqMember.VTQEmail;

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult VTQDetails(string id)
        {
            var member = _member.FirstOrDefault(x => x.VTQMemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            return View("VTQDetails", member);
        }
        [HttpGet]
        public IActionResult VTQDelete(string id)
        {
            var member = _member.FirstOrDefault(x => x.VTQMemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            return View("VTQDelete", member);
        }
        [HttpGet]
        public IActionResult VTQDeleted(string id)
        {
            var member = _member.FirstOrDefault(x => x.VTQMemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            _member.Remove(member);
            return RedirectToAction(nameof(Index));
        }
    }
}
