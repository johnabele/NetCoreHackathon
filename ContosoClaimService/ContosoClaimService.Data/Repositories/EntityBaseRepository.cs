using ConotosClaimService.Data;
using ContosoClaimService.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;

namespace ContosoClaimService.Data.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
                where T : class, new()
    {
        private ClaimServiceContext _context;

        public EntityBaseRepository(ClaimServiceContext context)
        {
            _context = context;
        }
        public virtual IEnumerable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();

            return query.AsEnumerable();
        }

        public virtual void Add(T entity)
        {
            EntityEntry dbEntityEntry = _context.Entry<T>(entity);
            _context.Set<T>().Add(entity);
        }

    }
}
