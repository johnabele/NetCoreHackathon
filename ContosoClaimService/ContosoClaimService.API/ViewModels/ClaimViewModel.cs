using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoClaimService.API.ViewModels
{
    public class ClaimViewModel
    {
        public string ClaimId { get; set; }
        public string MemberId { get; set; }
        public DateTime DateOfService { get; set; }
        public string ClaimStatus { get; set; }
        public string Provider { get; set; }
        public decimal AmountBilled { get; set; }
        public decimal AmountMemberResponsibility { get; set; }
    }
}
