using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Traning
    {
        [Key]
        public int Id { get; set; }
        public string TrainName { get; set; } = string.Empty;
        public string TrainDescription { get; set;} = string.Empty;
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public List<string> TypeTrain {  get; set; } = new List<string>();
        public string Status { get; set; } = string.Empty;
    }
}
