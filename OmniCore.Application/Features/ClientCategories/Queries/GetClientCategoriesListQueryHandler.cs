using OmniCore.Application.Contracts.Persistence;

namespace OmniCore.Application.Features.ClientCategories.Queries;

public class GetClientCategoriesListQueryHandler
    (IClientCategoryRepository clientCategoryRepository,
    IMapper mapper)
    : IRequestHandler<GetClientCategoriesListQuery, List<ClientCategoryListVm>>
{
    private readonly IClientCategoryRepository _clientCategoryRepository= clientCategoryRepository;
    private readonly IMapper _mapper= mapper;
    public Task<List<ClientCategoryListVm>> Handle(GetClientCategoriesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
