using HRM.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.API.Modes
{
    public class EmployeeRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int ShiftId { get; set; }
    }
}
