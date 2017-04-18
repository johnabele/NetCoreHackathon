using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoDashboard.Web.ViewModels
{
    public class DashboardViewModel
    {
        public MemberViewModel Member { get; set; }
        public List<ClaimViewModel> Claims { get; set; }
    }
}
