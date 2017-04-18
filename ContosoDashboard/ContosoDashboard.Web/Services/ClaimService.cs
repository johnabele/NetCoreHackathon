using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContosoDashboard.Web.Services
{
    public class ClaimService : IClaimService
    {
        private IConfiguration _configuration;
        public ClaimService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<JArray> GetClaimsByMemberId(int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(_configuration["ClaimService:baseUrl"])
            };

            var response = await client.GetAsync(_configuration["ClaimService:endpoint2"] + id);
            var output = await response.Content.ReadAsStringAsync();

            return JArray.Parse(output);
        }
        public async Task<JObject> GetClaimById(string id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(_configuration["ClaimService:baseUrl"])
            };

            var response = await client.GetAsync(_configuration["ClaimService:endpoint1"] + id);
            var output = await response.Content.ReadAsStringAsync();

            return JObject.Parse(output);
        }
    }
}
