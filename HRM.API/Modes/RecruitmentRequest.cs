using HRM.Models;

namespace HRM.API.Modes
{
    public class RecruitmentRequest
    {
        public string RecruitmentPosition { get; set; } = string.Empty;
        public DateTime PostingDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<string> Requestment { get; set; } = new List<string>();
        public string RecruitmentDescription { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
    }
}
