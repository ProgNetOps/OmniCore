using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.Switches.Queries;

public class GetSwitchesListQueryHandler : IRequestHandler<GetSwitchesListQuery, List<SwitchListVm>>
{
    public Task<List<SwitchListVm>> Handle(GetSwitchesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
