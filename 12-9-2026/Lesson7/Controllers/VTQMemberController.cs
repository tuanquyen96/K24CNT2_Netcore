using Lesson7.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson7.Controllers;

public class VTQMemberController : Controller
{
    private readonly List<VTQMember> _members = new()
    {
        new VTQMember
        {
            VTQMemberId = Guid.NewGuid().ToString(),
            VTQUserName = "adudu",
            VTQPassword = "123456",
            VTQFullName = "Vu Tuan Quyen",
            VTQEmail = "Radahotga1@gmail.com"
        },
        new VTQMember
        {
            VTQMemberId = Guid.NewGuid().ToString(),
            VTQUserName = "nguyenvana",
            VTQPassword = "123456",
            VTQFullName = "Nguyen Van A",
            VTQEmail = "nguyenvana@gmail.com"
        },
        new VTQMember
        {
            VTQMemberId = Guid.NewGuid().ToString(),
            VTQUserName = "tranthib",
            VTQPassword = "123456",
            VTQFullName = "Tran Thi B",
            VTQEmail = "tranthib@gmail.com"
        },
        new VTQMember
        {
            VTQMemberId = Guid.NewGuid().ToString(),
            VTQUserName = "leminhc",
            VTQPassword = "123456",
            VTQFullName = "Le Minh C",
            VTQEmail = "leminhc@gmail.com"
        },
        new VTQMember
        {
            VTQMemberId = Guid.NewGuid().ToString(),
            VTQUserName = "phamthid",
            VTQPassword = "123456",
            VTQFullName = "Pham Thi D",
            VTQEmail = "phamthid@gmail.com"
        }
    };

    public IActionResult Index()
    {
        return View(_members);
    }

    public IActionResult GetMember()
    {
        var member = new VTQMember
        {
            VTQMemberId = Guid.NewGuid().ToString(),
            VTQUserName = "Adudu",
            VTQPassword = "password123",
            VTQFullName = "Vu Tuan Quyen",
            VTQEmail = "radahotga1@gmail.com"
        };
        return View(member);
    }

    public IActionResult GetMembers()
    {
        return View(_members);
    }

    public IActionResult Create()
    {
        return View(new VTQMember());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(VTQMember member)
    {
        if (ModelState.IsValid)
        {
            member.VTQMemberId = Guid.NewGuid().ToString();
            _members.Add(member);
            return RedirectToAction(nameof(Index));
        }

        return View(member);
    }
}
