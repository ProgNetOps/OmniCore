using OmniCore.Application.Features.AlcatelRadioLastMiles.Queries;
using OmniCore.Application.Features.BTS.Queries;
using OmniCore.Application.Features.CeragonRadioLastMiles.Queries;
using OmniCore.Application.Features.ClientCategories.Queries;
using OmniCore.Application.Features.Clients.Queries;
using OmniCore.Application.Features.FiberLastMiles.Queries;
using OmniCore.Application.Features.InternetServices.Queries;
using OmniCore.Application.Features.IPPoPs.Queries;
using OmniCore.Application.Features.LeasedLineServices.Queries;
using OmniCore.Application.Features.Links.Queries;
using OmniCore.Application.Features.NeraRadioLastMiles.Queries;
using OmniCore.Application.Features.PettyCashVouchers.Queries;
using OmniCore.Application.Features.PRIServices.Queries;
using OmniCore.Application.Features.Routers.Queries;
using OmniCore.Application.Features.Servers.Queries;
using OmniCore.Application.Features.SIPServices.Queries;
using OmniCore.Application.Features.States.Queries;
using OmniCore.Application.Features.Switches.Queries;
using OmniCore.Application.Features.TechnicalRegions.Queries;
using OmniCore.Application.Features.Tickets.Queries;
using OmniCore.Application.Features.Units.Queries;
using OmniCore.Application.Features.UserCategoriess.Queries;
using OmniCore.Application.Features.Zones.Queries;

namespace OmniCore.Application.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<AlcatelRadioLastMile, AlcatelRadioLastMileListVm>().ReverseMap();

        CreateMap<BTS, BTSListVm>().ReverseMap();

        CreateMap<CeragonRadioLastMile, CeragonRadioLastMileListVm>().ReverseMap();

        CreateMap<ClientCategory, ClientCategoryListVm>().ReverseMap();

        CreateMap<Client, ClientListVm>().ReverseMap();

        CreateMap<FiberLastMile, FiberLastMileListVm>().ReverseMap();

        CreateMap<InternetService, InternetServiceListVm>().ReverseMap();

        CreateMap<IPPoP, IPPoPListVm>().ReverseMap();

        CreateMap<LeasedLineService, LeasedLineServiceListVm>().ReverseMap();

        CreateMap<Link, LinkListVm>().ReverseMap();

        CreateMap<NeraRadioLastMile, NeraRadioLastMileListVm>().ReverseMap();

        CreateMap<PettyCashVoucher, PettyCashVoucherListVm>().ReverseMap();

        CreateMap<PRIService, PRIServiceListVm>().ReverseMap();

        CreateMap<Router, RouterListVm>().ReverseMap();

        CreateMap<Server, ServerListVm>().ReverseMap();

        CreateMap<SIPService, SipServiceListVm>().ReverseMap();

        CreateMap<State, StateListVm>().ReverseMap();

        CreateMap<Switch, SwitchListVm>().ReverseMap();

        CreateMap<TechnicalRegion, TechnicalRegionListVm>().ReverseMap();

        CreateMap<Ticket, TicketListVm>().ReverseMap();

        CreateMap<SubUnit, SubUnitListVm>().ReverseMap();

        CreateMap<TechnicalRegion, TechnicalRegionListVm>().ReverseMap();

        CreateMap<UserCategory, UserCategoryListVm>().ReverseMap();

        CreateMap<Zone, ZoneListVm>().ReverseMap();

    }
}
