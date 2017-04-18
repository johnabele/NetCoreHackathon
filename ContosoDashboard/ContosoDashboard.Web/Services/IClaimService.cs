using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContosoDashboard.Web.Services
{
    public interface IClaimService
    {
        Task<JArray> GetClaimsByMemberId(int id);
        Task<JObject> GetClaimById (string id);
    }
}
