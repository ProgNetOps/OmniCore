using System;
using System.Collections.Generic;
using System.Text;

namespace OmniCore.Application.Features.SIPServices.Queries;

public class GetSIPServicesListQueryHandler : IRequestHandler<GetSIPServicesListQuery, List<SipServiceListVm>>
{
    public Task<List<SipServiceListVm>> Handle(GetSIPServicesListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
