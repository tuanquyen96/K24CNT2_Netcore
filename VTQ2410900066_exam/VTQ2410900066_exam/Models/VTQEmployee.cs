namespace VTQ2410900066_exam.Models;

public class VTQEmployee
{
    public int Id { get; set; }
    public string VTQName { get; set; } = string.Empty;
    public string? VTQGender { get; set; }
    public DateTime VTQBirthDay { get; set; }
    public string? VTQEmail { get; set; }
    public string? VTQPhone { get; set; }
    public bool VTQActive { get; set; }
}
