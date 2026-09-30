using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.Links.Queries;

public class GetLinksListQueryHandler 
    (ILinkRepository linkRepository,
    IMapper mapper)
    : IRequestHandler<GetLinksListQuery, List<LinkListVm>>
{
    private readonly ILinkRepository _linkRepository = linkRepository;
    private readonly IMapper _mapper=mapper;
    public Task<List<LinkListVm>> Handle(GetLinksListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
