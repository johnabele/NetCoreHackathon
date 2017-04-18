using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoDashboard.Web.Services;
using ContosoDashboard.Web.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoDashboard.Web.Controllers
{
    public class ClaimController : Controller
    {
        private IClaimService _claimService;
        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }
        // GET: /<controller>/
        public IActionResult Index(string id)
        {
            var claim = _claimService.GetClaimById(id);

            return View(claim.Result.ToObject<ClaimViewModel>());
        }
    }
}
