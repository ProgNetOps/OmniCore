using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.ClientCategories.Queries;

public class GetClientCategoriesListQueryHandler : IRequestHandler<GetClientCategoriesListQuery, List<ClientCategoryListVm>>
{
    public Task<List<ClientCategoryListVm>> Handle(GetClientCategoriesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
