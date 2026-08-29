
namespace Lesson4.Models;

public class VTQAccount
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public int Gender { get; set; } // 0: Male, 1: Female
    public DateTime Birthday { get; set; }
}
