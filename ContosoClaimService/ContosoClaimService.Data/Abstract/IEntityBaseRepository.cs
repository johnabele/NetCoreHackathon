using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ContosoClaimService.Data.Abstract
{
    public interface IEntityBaseRepository<T> where T : class, new()
    {
        T GetSingle(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

    }
}
