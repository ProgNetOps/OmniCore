using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.States.Queries;

public class GetStatesListQueryHandler : IRequestHandler<GetStatesListQuery, List<StateListVm>>
{
    public Task<List<StateListVm>> Handle(GetStatesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
