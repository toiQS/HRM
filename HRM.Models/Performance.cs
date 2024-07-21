using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Performance
    {
        [Key]
        public int Id { get; set; }
        public DateTime EvaluationDate {  get; set; }
        public int Score { get; set; }
        public string Comment { get; set; } = string.Empty;

        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        
        [ForeignKey(nameof(Traning))]
        public int TraningId { get; set; }
        public virtual Traning Traning { get; set; }

        [ForeignKey(nameof(Salary))]    
        public int SalaryId { get; set; }
        public virtual Salary Salary { get; set; }
    }
}
