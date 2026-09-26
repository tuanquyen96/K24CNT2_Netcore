using VTQ2410900066_exam.Models;

namespace VTQ2410900066_exam.Data;

public static class DataLocal
{
    public static List<VTQStudent> GetStudents() => new()
    {
        new VTQStudent { Id = 1, VTQName = "Vũ Tuấn Quyền", VTQGender = "Nam", VTQBirthDay = new DateTime(2006, 6, 9), VTQEmail = "radahotga1@gmail.com", VTQPhone = "0900000066", VTQActive = true },
        new VTQStudent { Id = 2, VTQName = "Nguyễn Minh Anh", VTQGender = "Nữ", VTQBirthDay = new DateTime(2006, 3, 15), VTQEmail = "minhanh@example.com", VTQPhone = "0912345678", VTQActive = true },
        new VTQStudent { Id = 3, VTQName = "Trần Hoàng Nam", VTQGender = "Nam", VTQBirthDay = new DateTime(2005, 11, 20), VTQEmail = "hoangnam@example.com", VTQPhone = "0987654321", VTQActive = false }
    };
}
