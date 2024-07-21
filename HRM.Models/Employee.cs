using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName {  get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime HireDate {  get; set; }
        
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        [ForeignKey(nameof(Shift))]
        public int ShiftId { get; set; }
        public virtual Shift Shift { get; set; }

        public List<Performance> Performances { get; set; } = new List<Performance>();
    }
}
