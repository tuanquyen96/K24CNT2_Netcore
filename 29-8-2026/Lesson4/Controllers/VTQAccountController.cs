using Microsoft.AspNetCore.Mvc;
using Lesson4.Models;

namespace Lesson4.Controllers
{
    public class VTQAccountController : Controller
    {
        public IActionResult VTQIndex()
        {
            var accounts = new List<VTQAccount>
            {
                new()
                {
                    Id = 1, Name = "Vũ Tuấn Quyền",     
                    Email = "quyen.vu@example.com",
                    Phone = "0901 234 567",
                    Avatar = "/images/1.jpg",
                    Address = "Hà Nội",
                    Bio = "Sinh viên K24CNT2", 
                    Gender = 0,
                    Birthday = new DateTime(2004, 5, 12)
                },
                new()
                {
                    Id = 2, Name = "Nguyễn Minh Anh", 
                    Email = "anh.nguyen@example.com",
                    Phone = "0902 345 678", 
                    Avatar = "/images/2.jpg",
                    Address = "Hải Phòng", 
                    Bio = "Sinh viên công nghệ thông tin", 
                    Gender = 1,
                    Birthday = new DateTime(2004, 8, 21)
                },
                new()
                {
                    Id = 3, Name = "Trần Hoàng Nam",
                    Email = "nam.tran@example.com",
                    Phone = "0903 456 789", 
                    Avatar = "/images/3.jpg",
                    Address = "Bắc Ninh", 
                    Bio = "Lập trình viên tương lai", 
                    Gender = 0,
                    Birthday = new DateTime(2003, 11, 3)
                },
                new()
                {
                    Id = 4, Name = "Lê Thu Hà",         
                    Email = "ha.le@example.com",
                    Phone = "0904 567 890",  
                    Avatar = "/images/4.jpg",
                    Address = "Nam Định", 
                    Bio = "Yêu thích thiết kế web", 
                    Gender = 1, 
                    Birthday = new DateTime(2004, 2, 15)
                }
            };

            return View(accounts);
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult VTQProfile()
        {
            VTQAccount vTQAccount = new VTQAccount
            {
                Id = 4,
                Name = "Lê Thu Hà",
                Email = "ha.le@example.com",
                Phone = "0904 567 890",
                Avatar = "/images/4.jpg",
                Address = "Nam Định",
                Bio = "Yêu thích thiết kế web",
                Gender = 1,
                Birthday = new DateTime(2004, 2, 15)
            };
            return View(vTQAccount);
        }
    }
}
