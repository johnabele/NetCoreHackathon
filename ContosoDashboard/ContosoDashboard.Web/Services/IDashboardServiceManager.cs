using ContosoDashboard.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoDashboard.Web.Services
{
    public interface IDashboardServiceManager
    {
        DashboardViewModel GetMemberData(int id);
    }
}
