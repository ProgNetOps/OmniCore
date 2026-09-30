using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.Servers.Queries;

public class GetServersListQueryHandler : IRequestHandler<GetServersListQuery, List<ServerListVm>>
{
    public Task<List<ServerListVm>> Handle(GetServersListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
