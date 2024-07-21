using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public List<string> DayOfApplication { get; set; } = new List<string>();
        public TimeOnly TotalHouse {  get; set; }
    }
}
