using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.TechnicalRegions.Queries;

public class GetTechnicalRegionsListQueryHandler : IRequestHandler<GetTechnicalRegionsListQuery, List<TechnicalRegionListVm>>
{
    public Task<List<TechnicalRegionListVm>> Handle(GetTechnicalRegionsListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
