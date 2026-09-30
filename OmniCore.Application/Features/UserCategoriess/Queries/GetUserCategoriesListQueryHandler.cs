using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.UserCategoriess.Queries;

public class GetUserCategoriesListQueryHandler : IRequestHandler<GetUserCategoriesListQuery, List<UserCategoryListVm>>
{
    public Task<List<UserCategoryListVm>> Handle(GetUserCategoriesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
