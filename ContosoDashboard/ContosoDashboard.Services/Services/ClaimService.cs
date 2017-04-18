using Newtonsoft.Json.Linq;

namespace ContosoDashboard.Services.Services
{
    public class ClaimService : IClaimService
    {
        public JObject GetClaims(int id)
        {
            var serviceClient = new ServiceClient();

            var output = serviceClient.GetAPIDataAsync(id);
            JObject jsonObj = JObject.Parse(output.Result);

            return jsonObj;
        }
    }
}
