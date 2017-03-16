using ContosoClaimService.Data.Abstract;
using ContosoClaimService.Data.Repositories;
using ContosoClaimService.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ConotosClaimService.Data.Repositories
{
    public class ClaimRepository : EntityBaseRepository<Claim>, IClaimRepository
    {
        private ClaimServiceContext _context;
        public ClaimRepository(ClaimServiceContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Claim> GetAll()
        {
            IQueryable<Claim> query = _context.Set<Claim>();

            return query.Include("Payment").AsEnumerable();
        }
    }
}
