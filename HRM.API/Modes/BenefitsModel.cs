using HRM.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.API.Modes
{
    public class BenefitsModel
    {
    }
    public class BenefitsResponse
    {
        public int Id { get; set; }
        public string BenefitsName { get; set; } = string.Empty;
        public string BenefitsDescription { get; set; } = string.Empty;
        public string TypeBenefits { get; set; } = string.Empty;
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int PositionId { get; set; }
    }
    public class BenefitsRequest
    {
        public string BenefitsName { get; set; } = string.Empty;
        public string BenefitsDescription { get; set; } = string.Empty;
        public string TypeBenefits { get; set; } = string.Empty;
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int PositionId { get; set; }
    }
}
