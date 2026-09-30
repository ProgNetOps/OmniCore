using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.LeasedLineServices.Queries;

public class GetLeasedLineServicesListQueryHandler 
    (ILeasedLineServiceRepository leasedLineServiceRepository,
    IMapper mapper)
    : IRequestHandler<GetLeasedLineServicesListQuery, List<LeasedLineServiceListVm>>
{
    private readonly ILeasedLineServiceRepository _leasedLineServiceRepository1 = leasedLineServiceRepository;
    private readonly IMapper _mapper=mapper;
    public Task<List<LeasedLineServiceListVm>> Handle(GetLeasedLineServicesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
