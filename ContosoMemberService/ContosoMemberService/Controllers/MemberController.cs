using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ContosoMemberService.Data.Abstract;

namespace ContosoMemberService.Controllers
{
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
        private readonly IMemberRepository _memberRepository;

        public MemberController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var member = _memberRepository.FindById(id);
            //prob some mapping
            return Json(member);
        }
    }
}
