namespace HRM.API.Modes
{
    public class TrainingRequest
    {
        public string TrainName { get; set; } = string.Empty;
        public string TrainDescription { get; set; } = string.Empty;
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public List<string> TypeTrain { get; set; } = new List<string>();
        public string Status { get; set; } = string.Empty;
    }
}
