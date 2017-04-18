using ContosoMemberService.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoMemberService.Data.Abstract
{
    public interface IMemberRepository : IEntityBaseRepository<Member> { }
}
