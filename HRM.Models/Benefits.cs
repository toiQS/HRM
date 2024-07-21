using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Benefits
    {
        [Key]
        public int Id {  get; set; }
        public string BenefitsName { get; set; } = string.Empty;
        public string BenefitsDescription { get; set; } = string.Empty;
        public string TypeBenefits {  get; set; } = string.Empty;
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
    }
}
