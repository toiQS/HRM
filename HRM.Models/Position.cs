using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string PositonName { get; set; } = string.Empty;
        public string PositonDescription { get; set; } = string.Empty;

    }
}
