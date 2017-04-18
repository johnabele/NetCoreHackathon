using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoMemberService.Data.Abstract
{
    public interface IEntityBaseRepository<T> where T : class, new()
    {
        IEnumerable<T> GetAll();
        T FindById(int id);
    }
}
