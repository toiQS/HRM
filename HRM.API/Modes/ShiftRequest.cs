namespace HRM.API.Modes
{
    public class ShiftRequest
    {
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public List<string> DayOfApplication { get; set; } = new List<string>();
        public TimeOnly TotalHours { get; set; }
    }
}
