using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public float BasicSalary {  get; set; }
        public float Bonus {  get; set; }
        public float Deductions { get; set; } 
        public float NetSalary { get; set; }
        public DateTime PaymentDate { get; set; }   
    }
}
