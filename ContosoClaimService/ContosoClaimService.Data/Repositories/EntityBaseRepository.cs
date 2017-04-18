using ConotosClaimService.Data;
using ContosoClaimService.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

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

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IEnumerable <T> item = null;
            IQueryable<T> dbQuery = _context.Set<T>();
            item = dbQuery
                    .AsNoTracking()
                    .Where(predicate)
                    .ToList();
            return item;
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            T item = null;
            IQueryable<T> dbQuery = _context.Set<T>();
            item = dbQuery
                    .AsNoTracking() 
                    .FirstOrDefault(predicate);
            return item;
        }
    }
}
