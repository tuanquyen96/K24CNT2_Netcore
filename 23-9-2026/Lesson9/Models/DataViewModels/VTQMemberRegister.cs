using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Lesson9.Models.DataViewModels
{
    /// <summary>
    /// Data Annotation - Validation
    /// </summary>
    public class VTQMemberRegister
    {
        public int VTQMemberId { get; set; }
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Tên đăng nhập phải từ 5 đến 50 ký tự")]
        public string VTQUserName { get; set; } = string.Empty;
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string VTQPassword { get; set; } = string.Empty;
        public string VTQEmail { get; set; } = string.Empty;
        public string VTQPhoneNumber { get; set; } = string.Empty;
        public string VTQFullName { get; set; } = string.Empty;
        public DateTime VTQBirthday { get; set; }
    }
}
