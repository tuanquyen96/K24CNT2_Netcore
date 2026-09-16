using System.ComponentModel;

namespace Lesson8Models.Models;

public class VTQMember
    {
        public string VTQMemberId { get; set; }
        public string VTQUserName { get; set; }
        public string VTQPassword { get; set; }
        [DisplayName("Họ và tên")]
        public string VTQFullName { get; set; }
        public string VTQEmail { get; set; }

}
