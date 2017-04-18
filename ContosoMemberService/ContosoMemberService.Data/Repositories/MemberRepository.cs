using ContosoMemberService.Data.Abstract;
using ContosoMemberService.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ContosoMemberService.Data.Repositories
{
    public class MemberRepository : EntityBaseRepository<Member>, IMemberRepository
    {
        private MemberServiceContext _context;
        public MemberRepository(MemberServiceContext context) : base(context)
        {
            _context = context;
        }
        public override Member FindById(int id)
        {
            return _context.Set<Member>().FromSql("spGetMemberById {0}", id).SingleOrDefault();
        }
    }
}
