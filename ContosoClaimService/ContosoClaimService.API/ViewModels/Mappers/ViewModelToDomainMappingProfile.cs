using AutoMapper;
using ContosoClaimService.Model.Entities;

namespace ContosoClaimService.API.ViewModels.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClaimViewModel, Claim>()
               .ForMember(c => c.Payment, map => map.UseValue(new Payment()));

            CreateMap<PaymentViewModel, Payment>();
        }
    }
}