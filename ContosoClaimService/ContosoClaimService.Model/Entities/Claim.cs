using System;

namespace ContosoClaimService.Model.Entities
{
    public class Claim
    {
        public string ClaimId { get; set; }
        public string PolicyId { get; set; }
        public DateTime DateOfClaim { get; set; }
        public DateTime DateOfSettlement { get; set; }     
        public Payment Payment { get; set; }

    }
}
