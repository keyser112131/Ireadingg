using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserReportComment
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime ModifyDate { get; set; }
        public string? Image { get; set; }
        public int? UserReportId { get; set; }
        public UserReport? UserReport { get; set; }
        public string? CreateBy { get; set; }
        public string? UserId { get; set; }
        public Account? User { get; set; }
    }
}
