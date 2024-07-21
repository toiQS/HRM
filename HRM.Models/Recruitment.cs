using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Recruitment
    {
        [Key]
        public int Id { get; set; }
        public string Position { get; set; } = string.Empty;
        public DateTime PostingDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<string> Requestment { get; set; } = new List<string>();
        public string RecruitmentDescription { get; set; } = string.Empty;
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; } 
        public virtual Department Department { get; set; }
    }
}
