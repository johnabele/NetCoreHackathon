using Microsoft.AspNetCore.Mvc;
using ContosoDashboard.Web.Services;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoDashboard.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDashboardServiceManager _dashboardServiceManager;
        public HomeController(IDashboardServiceManager dashboardServiceManager)
        {
            _dashboardServiceManager = dashboardServiceManager;
        }
        // GET: /<controller>/
        [Authorize]
        public IActionResult Index()
        {
            var userId = 3;
            var dashboardVM = _dashboardServiceManager.GetMemberData(userId);

            return View(dashboardVM);
        }
    }
}
