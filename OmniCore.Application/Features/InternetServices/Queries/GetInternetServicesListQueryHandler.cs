using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.InternetServices.Queries;

public class GetInternetServicesListQueryHandler
    (IInternetServiceRepository internetServiceRepository,
    IMapper mapper)
    : IRequestHandler<GetInternetServicesListQuery, List<InternetServiceListVm>>
{
    private readonly IInternetServiceRepository _internetServiceRepository = internetServiceRepository;
    private readonly IMapper _mapper = mapper;
    public Task<List<InternetServiceListVm>> Handle(GetInternetServicesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
