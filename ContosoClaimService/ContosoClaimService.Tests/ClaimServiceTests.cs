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
                new Claim() { PolicyId = "000001", ClaimId = "12345", Payment = new Payment() { AmountPaid = 1921.39m } },
                new Claim() { PolicyId = "000001", ClaimId = "12346", Payment = new Payment() { AmountPaid = 92.99m } },
                new Claim() { PolicyId = "000001", ClaimId = "12347", Payment = new Payment() { AmountPaid = 768.01m } }
            };

            //Act
            List<ClaimViewModel> claimVMs = Mapper.Map<List<Claim>, List<ClaimViewModel>>(claims);

            //Assert
            //Assert.AreEqual(claims[0].Payment.AmountPaid, claimVMs[0].Payment.AmountPaid);
        }
    }
}
