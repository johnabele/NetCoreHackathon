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
        [HttpGet("GetClaimsByMember/{id}")]
        public IActionResult GetClaimsByMember(int id)
        {
            var _claims = _claimRepository.FindBy(x => x.MemberId == id.ToString());
            IEnumerable<ClaimViewModel> claimVMs = Mapper.Map<IEnumerable<Claim>, IEnumerable<ClaimViewModel>>(_claims);

            return Json(claimVMs);
        }
        [HttpGet("GetClaimById/{id}")]
        public IActionResult GetClaimById(string id)
        {
            var _claims = _claimRepository.GetSingle(x => x.ClaimId == id);
            ClaimViewModel claimVM = Mapper.Map<Claim, ClaimViewModel>(_claims);

            return Json(claimVM);
        }
    }
}
