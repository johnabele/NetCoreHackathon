using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDashboard.Services.Services
{
    public class MemberService : IMemberService
    {
        public JObject GetMember(int id)
        {
            var serviceClient = new ServiceClient();

            var output = serviceClient.GetAPIDataAsync(id);
            JObject jsonObj = JObject.Parse(output.Result);

            return jsonObj;
        }
    }
}
