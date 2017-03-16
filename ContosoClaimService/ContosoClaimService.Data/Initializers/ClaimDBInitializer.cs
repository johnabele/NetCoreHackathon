using ContosoClaimService.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ConotosClaimService.Data.Initializers
{
    public static class ClaimDBInitializer
    {
        private static ClaimServiceContext context;
        public static void Initialize(IServiceProvider serviceProvider)
        {
            context = (ClaimServiceContext)serviceProvider.GetService(typeof(ClaimServiceContext));

            InitializeClaims();

        }
        private static void InitializeClaims()
        {
            context.Database.EnsureCreated();

            if (context.Claims.Any())
            {
                return;   // DB has already been seeded
            }

            IList<Claim> claims = new List<Claim>();

            claims.Add(new Claim() { PolicyId = "000001", ClaimId = "12345", Payment = new Payment() { AmountPaid = 1921.39m } });
            claims.Add(new Claim() { PolicyId = "000001", ClaimId = "12346", Payment = new Payment() { AmountPaid = 92.99m } });
            claims.Add(new Claim() { PolicyId = "000001", ClaimId = "12347", Payment = new Payment() { AmountPaid = 768.01m } });

            foreach (Claim claim in claims)
            {
                context.Claims.Add(claim);
            }
            context.SaveChanges();
        }
    }
}
