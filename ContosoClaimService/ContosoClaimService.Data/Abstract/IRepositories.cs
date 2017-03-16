using ContosoClaimService.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoClaimService.Data.Abstract
{
    public interface IClaimRepository : IEntityBaseRepository<Claim> { }
}
