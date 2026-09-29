using OmniCore.Application.Features.AlcatelRadioLastMiles.Queries;
using OmniCore.Application.Features.BTS.Queries;
using OmniCore.Application.Features.CeragonRadioLastMiles.Queries;

namespace OmniCore.Application.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<AlcatelRadioLastMile, AlcatelRadioLastMileListVm>().ReverseMap();

        CreateMap<BTS, BTSListVm>().ReverseMap();

        CreateMap<CeragonRadioLastMile, CeragonRadioLastMileListVm>().ReverseMap();

        CreateMap<AlcatelRadioLastMile, AlcatelRadioLastMileListVm>().ReverseMap();

    }
}
