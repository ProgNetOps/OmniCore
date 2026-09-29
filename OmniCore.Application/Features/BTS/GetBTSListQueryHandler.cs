using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.BTS;

public class GetBTSListQueryHandler
    (IBTSRepository bTSRepository,
    IMapper mapper) 
    : IRequestHandler<GetBTSListQuery, List<BTSListVm>>
{
    private readonly IBTSRepository _bTSRepository = bTSRepository;
    private readonly IMapper _mapper = mapper;
    public Task<List<BTSListVm>> Handle(GetBTSListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
