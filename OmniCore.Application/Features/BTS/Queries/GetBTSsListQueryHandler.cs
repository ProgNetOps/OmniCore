using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.BTS.Queries;

public class GetBTSsListQueryHandler
    (IBTSRepository bTSRepository,
    IMapper mapper) 
    : IRequestHandler<GetBTSsListQuery, List<BTSListVm>>
{
    private readonly IBTSRepository _bTSRepository = bTSRepository;
    private readonly IMapper _mapper = mapper;
    public Task<List<BTSListVm>> Handle(GetBTSsListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
