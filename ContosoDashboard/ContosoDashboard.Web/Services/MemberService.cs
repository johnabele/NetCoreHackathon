using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ContosoDashboard.Web.Services
{
    public class MemberService : IMemberService
    {
        private IConfiguration _configuration;
        public MemberService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<JObject> GetMember(int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(_configuration["MemberService:baseUrl"])
            };

            var response = await client.GetAsync(_configuration["MemberService:endpoint"] + id);
            var output = await response.Content.ReadAsStringAsync();

            return JObject.Parse(output);
        }
    }
}
