using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContosoDashboard.Web.Services
{
    public interface IMemberService
    {
        Task<JObject> GetMember(int id);
    }
}
