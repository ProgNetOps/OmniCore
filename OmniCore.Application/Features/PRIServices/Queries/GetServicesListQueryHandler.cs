using OmniCore.Application.Features.Servers.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.PRIServices.Queries;

public class GetPRIServicesListQueryHandler : IRequestHandler<GetPRIServicesListQuery, List<PRIServiceListVm>>
{
    public Task<List<PRIServiceListVm>> Handle(GetPRIServicesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
