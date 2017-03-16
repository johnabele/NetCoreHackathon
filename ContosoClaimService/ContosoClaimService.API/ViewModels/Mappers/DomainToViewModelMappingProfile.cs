using AutoMapper;
using ContosoClaimService.Model.Entities;

namespace ContosoClaimService.API.ViewModels.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Claim, ClaimViewModel>()
                .ForMember(vm => vm.ClaimId,
                map => map.MapFrom(e => e.ClaimId))
                .ForMember(vm => vm.PolicyId,
                map => map.MapFrom(e => e.PolicyId))
                .ForMember(vm => vm.DateOfClaim,
                map => map.MapFrom(e => e.DateOfClaim))
                .ForMember(vm => vm.DateOfSettlement,
                map => map.MapFrom(e => e.DateOfSettlement));

            CreateMap<Payment, PaymentViewModel>()
                .ForMember(vm => vm.PaymentId,
                map => map.MapFrom(e => e.PaymentId))
                .ForMember(vm => vm.AmountPaid,
                map => map.MapFrom(e => e.AmountPaid));
        }
    }
}