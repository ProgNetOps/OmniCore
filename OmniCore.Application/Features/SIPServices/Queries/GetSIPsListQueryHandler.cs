using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.SIPServices.Queries;

public class GetSIPsListQueryHandler : IRequestHandler<GetSIPsListQuery, List<SipListVm>>
{
    public Task<List<SipListVm>> Handle(GetSIPsListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
