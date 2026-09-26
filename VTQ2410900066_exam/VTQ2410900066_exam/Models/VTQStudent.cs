using System.ComponentModel.DataAnnotations;

namespace VTQ2410900066_exam.Models;

public class VTQStudent
{
    public int Id { get; set; }
    [Display(Name = "Họ và tên")]
    public string VTQName { get; set; } = string.Empty;
    [Display(Name = "Giới tính")]
    public string? VTQGender { get; set; }
    [Display(Name = "Ngày sinh")]
    [DataType(DataType.Date)]
    public DateTime VTQBirthDay { get; set; }
    [Display(Name = "Email")]
    [EmailAddress]
    public string? VTQEmail { get; set; }
    [Display(Name = "Số điện thoại")]
    public string? VTQPhone { get; set; }
    [Display(Name = "Hoạt động")]
    public bool VTQActive { get; set; }
}
