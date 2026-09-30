using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.Units.Queries;

public class GetUnitsListQueryHandler : IRequestHandler<GetUnitsListQuery, List<UnitListVm>>
{
    public Task<List<UnitListVm>> Handle(GetUnitsListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
