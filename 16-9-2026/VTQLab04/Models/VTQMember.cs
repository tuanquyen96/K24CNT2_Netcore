using System.ComponentModel.DataAnnotations;

namespace VTQLab04.Models
{
    public class VTQMember
    {
        [Display(Name = "Mã thành viên")]
        [Required(ErrorMessage = "Vui lòng nhập mã thành viên")]
        public string VTQMemberId { get; set; } = Guid.NewGuid().ToString();

        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        public string VTQUserName { get; set; } = "";

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string VTQPassword { get; set; } = "";

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string VTQFullName { get; set; } = "";

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string VTQEmail { get; set; } = "";

        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; } = "images/avatar/01.svg";
    }
}
