namespace Lesson9.Models.DataModels;

public class VTQMember
{
    public int VTQMemberId { get; set; }
    public string VTQUserName { get; set; } = string.Empty;
    public string VTQPassword { get; set; } = string.Empty;
    public string VTQEmail { get; set; } = string.Empty;
    public string VTQPhoneNumber { get; set; } = string.Empty;
    public string VTQFullName { get; set; } = string.Empty;
    public DateTime VTQBirthday { get; set; }
}
