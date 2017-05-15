using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ContosoClaimService.API.ViewModels;
using ContosoClaimService.Model.Entities;
using AutoMapper;

namespace ContosoClaimService.Tests
{
    [TestClass]
    public class ClaimServiceTests
    {
        [TestMethod]
        public void ClaimService_MappingEntityToDto_ReturnsEquivalentValues()
        {
            //Arrage
            List<Claim> claims = new List<Claim>
            {
                new Claim() { ClaimId = "840000120001", MemberId = "1", DateOfService = new DateTime(2017, 3, 8), ClaimStatus = "In Progress", Provider = "Walgreens #12273", AmountBilled = 378.00m, AmountMemberResponsibility = 24.75m },
                new Claim() { ClaimId = "839500120044", MemberId = "1", DateOfService = new DateTime(2017, 1, 14), ClaimStatus = "Completed", Provider = "ORAL FACIAL SURGERY CENTER", AmountBilled = 912.00m, AmountMemberResponsibility = 314.00m },
                new Claim() { ClaimId = "839211128735", MemberId = "1", DateOfService = new DateTime(2016, 8, 22), ClaimStatus = "Completed", Provider = "COLLINS D REID", AmountBilled = 654.00m, AmountMemberResponsibility = 94.67m },
            };

            //Act
            //List<ClaimViewModel> claimVMs = Mapper.Map<List<Claim>, List<ClaimViewModel>>(claims);

            //Assert
            //Assert.AreEqual(claims[0].Payment.AmountPaid, claimVMs[0].Payment.AmountPaid);
        }
    }
}
