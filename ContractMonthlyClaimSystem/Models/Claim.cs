namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {

        public int ClaimId { get; set; }
        public int LecturerId { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; } = 200; //Predefined rate

        public decimal TotalAmount { get; set; }//Calculated as HoursWorked
        public DateTime SubmissionDate { get; set; }
        public string Status { get; set; } //Pending , Approved, Rejected
    }
}
