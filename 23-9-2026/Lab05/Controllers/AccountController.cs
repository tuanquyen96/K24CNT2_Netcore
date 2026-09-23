using System.Text.RegularExpressions;
using Lab05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab05.Controllers
{
    public class AccountController : Controller
    {
        private static readonly List<Account> _accounts = new()
        {
            new Account
            {
                Id = 1,
                FullName = "Vũ Tuấn Quyền",
                Email = "radahotga1@gmail.com",
                Phone = "0901234567",
                Address = "Hà Nội",
                Avatar = "",
                Birthday = new DateTime(2006, 6, 9),
                Gender = "Nam",
                Password = "123456",
                Facebook = "https://facebook.com"
            }
        };

        public IActionResult Index()
        {
            return View(_accounts);
        }

        public IActionResult Details(int id)
        {
            var account = _accounts.FirstOrDefault(x => x.Id == id);
            if (account == null) return NotFound();
            return View(account);
        }

        public IActionResult Create()
        {
            return View(new Account());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account account)
        {
            if (!ModelState.IsValid) return View(account);

            account.Id = _accounts.Count == 0 ? 1 : _accounts.Max(x => x.Id) + 1;
            _accounts.Add(account);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var account = _accounts.FirstOrDefault(x => x.Id == id);
            if (account == null) return NotFound();
            return View(account);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Account account)
        {
            if (id != account.Id) return NotFound();
            if (!ModelState.IsValid) return View(account);

            var current = _accounts.FirstOrDefault(x => x.Id == id);
            if (current == null) return NotFound();

            current.FullName = account.FullName;
            current.Email = account.Email;
            current.Phone = account.Phone;
            current.Address = account.Address;
            current.Avatar = account.Avatar;
            current.Birthday = account.Birthday;
            current.Gender = account.Gender;
            current.Password = account.Password;
            current.Facebook = account.Facebook;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var account = _accounts.FirstOrDefault(x => x.Id == id);
            if (account == null) return NotFound();
            return View(account);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var account = _accounts.FirstOrDefault(x => x.Id == id);
            if (account != null) _accounts.Remove(account);
            return RedirectToAction(nameof(Index));
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            var isPhone = new Regex(@"^(\([0-9]{3}\)|[0-9]{3})[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (!isPhone.IsMatch(phone ?? string.Empty))
            {
                return Json($"Số điện thoại {phone} không đúng định dạng, VD: 0986421127 hoặc 098.421.1127");
            }

            return Json(true);
        }
    }
}
