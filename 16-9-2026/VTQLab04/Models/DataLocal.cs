namespace VTQLab04.Models
{
    public class DataLocal
    {
        public static List<VTQMember> _members = new List<VTQMember>
        {
            new VTQMember
            {
                VTQMemberId = Guid.NewGuid().ToString(),
                VTQUserName = "Adudu",
                VTQPassword = "123456",
                VTQFullName = "Vu Tuan Quyen",
                VTQEmail = "radahotga1@gmail.com",
                Avatar = "images/avatar/01.svg"
            },
            new VTQMember
            {
                VTQMemberId = Guid.NewGuid().ToString(),
                VTQUserName = "quyen02",
                VTQPassword = "123456",
                VTQFullName = "Tran Van Nam",
                VTQEmail = "nam02@gmail.com",
                Avatar = "images/avatar/02.svg"
            },
            new VTQMember
            {
                VTQMemberId = Guid.NewGuid().ToString(),
                VTQUserName = "quyen03",
                VTQPassword = "123456",
                VTQFullName = "Le Minh Anh",
                VTQEmail = "minhanh03@gmail.com",
                Avatar = "images/avatar/01.svg"
            },
            new VTQMember
            {
                VTQMemberId = Guid.NewGuid().ToString(),
                VTQUserName = "quyen04",
                VTQPassword = "123456",
                VTQFullName = "Pham Hoang Long",
                VTQEmail = "long04@gmail.com",
                Avatar = "images/avatar/04.svg"
            },
            new VTQMember
            {
                VTQMemberId = Guid.NewGuid().ToString(),
                VTQUserName = "quyen05",
                VTQPassword = "123456",
                VTQFullName = "Do Thi Hoa",
                VTQEmail = "hoa05@gmail.com",
                Avatar = "images/avatar/02.svg"
            }
        };

        public static List<VTQMember> GetVTQMembers()
        {
            return _members;
        }

        public static VTQMember? GetVTQMemberById(string id)
        {
            return _members.FirstOrDefault(x => x.VTQMemberId == id);
        }
    }
}
