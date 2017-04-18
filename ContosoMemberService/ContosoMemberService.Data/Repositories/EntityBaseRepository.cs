using ContosoMemberService.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContosoMemberService.Data.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
                   where T : class, new()
    {
        private MemberServiceContext _context;
        public EntityBaseRepository(MemberServiceContext context)
        {
            _context = context;
        }
        public virtual T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }


        public virtual IEnumerable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();

            return query.AsEnumerable();
        }
    }
}
