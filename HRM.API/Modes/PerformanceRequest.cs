using HRM.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.API.Modes
{
    public class PerformanceRequest
    {
        public DateTime EvaluationDate { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; } = string.Empty;    
        public int EmployeeId { get; set; }
        public int TrainingId { get; set; }
        public int SalaryId { get; set; }
    }
}
