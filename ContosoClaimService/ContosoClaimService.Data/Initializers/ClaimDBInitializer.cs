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

            IList<Claim> claims = new List<Claim>
            {
                new Claim() { ClaimId = "840000120001", MemberId = "1", DateOfService = new DateTime(2017, 3, 8), ClaimStatus = "In Progress", Provider = "Walgreens #12273", AmountBilled = 378.00m, AmountMemberResponsibility = 24.75m },
                new Claim() { ClaimId = "839500120042", MemberId = "1", DateOfService = new DateTime(2017, 1, 14), ClaimStatus = "Completed", Provider = "ORAL FACIAL SURGERY CENTER", AmountBilled = 912.00m, AmountMemberResponsibility = 314.00m },
                new Claim() { ClaimId = "839211128733", MemberId = "1", DateOfService = new DateTime(2016, 8, 22), ClaimStatus = "Completed", Provider = "COLLINS D REID", AmountBilled = 654.00m, AmountMemberResponsibility = 94.67m },
                new Claim() { ClaimId = "840000120004", MemberId = "2", DateOfService = new DateTime(2017, 3, 8), ClaimStatus = "In Progress", Provider = "Walgreens #12273", AmountBilled = 378.00m, AmountMemberResponsibility = 24.75m },
                new Claim() { ClaimId = "839500120045", MemberId = "2", DateOfService = new DateTime(2017, 1, 14), ClaimStatus = "Completed", Provider = "ORAL FACIAL SURGERY CENTER", AmountBilled = 912.00m, AmountMemberResponsibility = 314.00m },
                new Claim() { ClaimId = "839211128736", MemberId = "2", DateOfService = new DateTime(2016, 8, 22), ClaimStatus = "Completed", Provider = "COLLINS D REID", AmountBilled = 654.00m, AmountMemberResponsibility = 94.67m },
                new Claim() { ClaimId = "840000120007", MemberId = "3", DateOfService = new DateTime(2017, 3, 8), ClaimStatus = "In Progress", Provider = "Walgreens #12273", AmountBilled = 378.00m, AmountMemberResponsibility = 24.75m },
                new Claim() { ClaimId = "839500120048", MemberId = "3", DateOfService = new DateTime(2017, 1, 14), ClaimStatus = "Completed", Provider = "ORAL FACIAL SURGERY CENTER", AmountBilled = 912.00m, AmountMemberResponsibility = 314.00m },
                new Claim() { ClaimId = "839211128739", MemberId = "3", DateOfService = new DateTime(2016, 8, 22), ClaimStatus = "Completed", Provider = "COLLINS D REID", AmountBilled = 654.00m, AmountMemberResponsibility = 94.67m },
                new Claim() { ClaimId = "840000120099", MemberId = "4", DateOfService = new DateTime(2017, 3, 8), ClaimStatus = "In Progress", Provider = "Walgreens #12273", AmountBilled = 378.00m, AmountMemberResponsibility = 24.75m },
                new Claim() { ClaimId = "839500120088", MemberId = "4", DateOfService = new DateTime(2017, 1, 14), ClaimStatus = "Completed", Provider = "ORAL FACIAL SURGERY CENTER", AmountBilled = 912.00m, AmountMemberResponsibility = 314.00m },
                new Claim() { ClaimId = "839211128777", MemberId = "4", DateOfService = new DateTime(2016, 8, 22), ClaimStatus = "Completed", Provider = "COLLINS D REID", AmountBilled = 654.00m, AmountMemberResponsibility = 94.67m },
                new Claim() { ClaimId = "840000120066", MemberId = "5", DateOfService = new DateTime(2017, 3, 8), ClaimStatus = "In Progress", Provider = "Walgreens #12273", AmountBilled = 378.00m, AmountMemberResponsibility = 24.75m },
                new Claim() { ClaimId = "839500120055", MemberId = "5", DateOfService = new DateTime(2017, 1, 14), ClaimStatus = "Completed", Provider = "ORAL FACIAL SURGERY CENTER", AmountBilled = 912.00m, AmountMemberResponsibility = 314.00m },
                new Claim() { ClaimId = "839211128744", MemberId = "5", DateOfService = new DateTime(2016, 8, 22), ClaimStatus = "Completed", Provider = "COLLINS D REID", AmountBilled = 654.00m, AmountMemberResponsibility = 94.67m }
            };
            foreach (Claim claim in claims)
            {
                context.Claims.Add(claim);
            }
            context.SaveChanges();
        }
    }
}
