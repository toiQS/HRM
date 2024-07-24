namespace HRM.API.Modes
{
    public class SalaryRequest
    {
        public float BasicSalary { get; set; }
        public float Bonus { get; set; }
        public float Deductions { get; set; }
        public float NetSalary { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
