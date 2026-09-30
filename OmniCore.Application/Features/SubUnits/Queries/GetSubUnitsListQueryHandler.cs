using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.Units.Queries;

public class GetSubUnitsListQueryHandler : IRequestHandler<GetSubUnitsListQuery, List<SubUnitListVm>>
{
    public Task<List<SubUnitListVm>> Handle(GetSubUnitsListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
