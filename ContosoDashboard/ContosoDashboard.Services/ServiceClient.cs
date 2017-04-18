using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ContosoDashboard.Services
{
    public class ServiceClient
    {
        public async Task<string> GetAPIDataAsync(int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8003/")
            };

            var response = await client.GetAsync("api/Member/GetById/" + id);
            var output = await response.Content.ReadAsStringAsync();

            return output;
        }
    }
}
