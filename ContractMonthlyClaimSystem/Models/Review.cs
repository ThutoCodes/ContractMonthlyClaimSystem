namespace ContractMonthlyClaimSystem.Models
{
    public class Review
    {

        public int ReviewID { get; set; }
        public int ClaimID { get; set; }
        public string ReviewedBy { get; set; }// Coordinator or Manager
        public DateTime ReviewDate { get; set; }
        public string Decision { get; set; }//Approved or Rejected
        public string Comments { get; set; }
    }
}
