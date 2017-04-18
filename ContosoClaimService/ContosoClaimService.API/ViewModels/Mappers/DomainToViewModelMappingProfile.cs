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
                .ForMember(vm => vm.MemberId,
                map => map.MapFrom(e => e.MemberId))
                .ForMember(vm => vm.DateOfService,
                map => map.MapFrom(e => e.DateOfService))
                .ForMember(vm => vm.ClaimStatus,
                map => map.MapFrom(e => e.ClaimStatus))
                .ForMember(vm => vm.Provider,
                map => map.MapFrom(e => e.Provider))
                .ForMember(vm => vm.AmountBilled,
                map => map.MapFrom(e => e.AmountBilled))
                .ForMember(vm => vm.AmountMemberResponsibility,
                map => map.MapFrom(e => e.AmountMemberResponsibility));
        }
    }
}