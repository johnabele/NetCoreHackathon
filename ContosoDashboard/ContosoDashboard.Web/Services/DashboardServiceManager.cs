using ContosoDashboard.Web.Services;
using ContosoDashboard.Web.ViewModels;
using System.Collections.Generic;

namespace ContosoDashboard.Web.Services
{
    public class DashboardServiceManager : IDashboardServiceManager
    {
        private IMemberService _memberService;
        private IClaimService _claimService;
        public DashboardServiceManager(IMemberService memberService, IClaimService claimService)
        {
            _memberService = memberService;
            _claimService = claimService;
        }
        public DashboardViewModel GetMemberData(int id)
        {
            var memberObj = _memberService.GetMember(id);
            var claimsObj = _claimService.GetClaimsByMemberId(id);

            var dashboardVM = new DashboardViewModel()
            {
                Member = memberObj.Result.ToObject<MemberViewModel>(),
                Claims = claimsObj.Result.ToObject<List<ClaimViewModel>>()
            };

            return dashboardVM;
        }
    }
}
