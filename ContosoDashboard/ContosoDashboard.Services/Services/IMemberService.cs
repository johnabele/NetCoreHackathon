using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDashboard.Services.Services
{
    public interface IMemberService
    {
        JObject GetMember(int id);
    }
}
