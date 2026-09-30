using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.Routers.Queries;

public class GetRoutersListQueryHandler : IRequestHandler<GetRoutersListQuery, List<RouterListVm>>
{
    public Task<List<RouterListVm>> Handle(GetRoutersListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
