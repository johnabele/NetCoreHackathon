using AutoMapper;
using ContosoClaimService.API.ViewModels;
using ContosoClaimService.Data.Abstract;
using ContosoClaimService.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContosoClaimService.Controllers
{
    [Route("api/[controller]")]
    public class ClaimController : Controller
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }
        [HttpGet("GetAllClaims", Name = "GetAllClaims")]
        public IActionResult GetAllClaims()
        {
            var _claims = _claimRepository.GetAll();
            IEnumerable<ClaimViewModel> claimVMs = Mapper.Map<IEnumerable<Claim>, IEnumerable<ClaimViewModel>>(_claims);

            return Json(claimVMs);
        }

    }
}
