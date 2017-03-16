using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoClaimService.API.ViewModels
{
    public class ClaimViewModel
    {
        public string ClaimId { get; set; }
        public string PolicyId { get; set; }
        public DateTime DateOfClaim { get; set; }
        public DateTime DateOfSettlement { get; set; }
        public PaymentViewModel Payment { get; set; }
    }
}
